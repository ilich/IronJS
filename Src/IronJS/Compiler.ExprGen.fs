﻿namespace IronJS.Compiler

open IronJS
open IronJS.Utils
open IronJS.Tools
open IronJS.Compiler
open IronJS.Compiler.Helpers.Core

module ExprGen = 

  type private Builder = Ast.Node -> Context -> Et

  let private assign (ctx:Context) left right =
    let value = (ctx.Builder ctx right)

    match left with
    | Ast.Global(name, globalScopeLevel) -> Helpers.Variable.Globals.assign ctx name value globalScopeLevel
    | Ast.Local(name, localScopeLevel) -> Helpers.Variable.Locals.assign ctx name value localScopeLevel
    | Ast.Property(target, name) -> Helpers.ExprGen.setProperty (ctx.Builder ctx target) name value
    | _ -> Dlr.Expr.dynamicDefault

  let private functionDefine ctx (scope:Ast.Scope) ast =
    let closureType, closureExpr = Helpers.Closure.newClosure ctx scope
    Helpers.ExprGen.newFunction closureType [Dlr.Expr.constant ast; closureExpr; ctx.Environment]

  let private functionInvoke (ctx:Context) target args =
    Helpers.ExprGen.callFunction (ctx.Builder ctx target)  (ctx.Globals :: [for arg in args -> ctx.Builder ctx arg])

  let private objectShorthand (ctx:Context) properties =
    match properties with
    | Some(_) -> failwith "Objects with auto-properties not supported"
    | None -> Dlr.Expr.newArgs Runtime.Object.TypeDef [ctx.Environment]

  let private dynamicScope (ctx:Context) target body =
    let push = Helpers.ExprGen.pushDynamicScope ctx (ctx.Builder ctx target)
    let body = ctx.Builder ctx body
    let pop = Helpers.ExprGen.popDynamicScope ctx
    Dlr.Expr.block [push; body; pop]

  //Builder function for expression generation
  let internal builder (ctx:Context) (ast:Ast.Node) =
    match ast with
    | Ast.Assign(left, right) -> assign ctx left right
    | Ast.Global(name, globalScopeLevel) -> Helpers.Variable.Globals.dlrValueExpr ctx name globalScopeLevel
    | Ast.Local(name, localScopeLevel) -> Helpers.Variable.Locals.dlrValueExpr ctx name localScopeLevel
    | Ast.Closure(name, scopeLevels) -> Helpers.Variable.Closure.dlrValueExpr ctx name scopeLevels
    | Ast.Property(target, name) -> Helpers.ExprGen.getProperty (ctx.Builder ctx target) name
    | Ast.Block(nodes) -> Dlr.Expr.block [for node in nodes -> ctx.Builder ctx node]
    | Ast.String(value) -> Dlr.Expr.constant value
    | Ast.Number(value) -> Dlr.Expr.constant value
    | Ast.Return(value) -> Js.makeReturn ctx.Return (ctx.Builder ctx value)
    | Ast.Function(scope, _) -> functionDefine ctx scope ast
    | Ast.DynamicScope(target, body) -> dynamicScope ctx target body
    | Ast.Invoke(target, args) -> functionInvoke ctx target args
    | Ast.Object(properties) -> objectShorthand ctx properties
    | Ast.Pass -> Dlr.Expr.empty
    | _ -> Dlr.Expr.dynamicDefault