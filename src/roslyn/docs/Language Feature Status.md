Language Feature Status
=====

This document reflects the status, and planned work in progress, for the compiler team.  It is a live document
and will be updated as work progresses, features are added / removed, and as work on feature progresses.
This is not an exhaustive list of our features but rather the ones which have active development
efforts behind them.

# C# Next

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [Semi-auto-properties](https://github.com/dotnet/csharplang/issues/140) | [semi-auto-props](https://github.com/dotnet/roslyn/tree/features/semi-auto-props) | [In Progress](https://github.com/dotnet/roslyn/issues/57012) | [Youssef1313](https://github.com/Youssef1313) | [333fred](https://github.com/333fred), [RikkiGibson](https://github.com/RikkiGibson) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) |
| [Top Level statement attribute specifiers](https://github.com/dotnet/csharplang/issues/5045) | [main-attributes](https://github.com/dotnet/roslyn/tree/features/main-attributes) | [In Progress](https://github.com/dotnet/roslyn/issues/57047) | [chsienki](https://github.com/chsienki) | [cston](https://github.com/cston), [333fred](https://github.com/333fred) | [jaredpar](https://github.com/jaredpar) |
| [Primary Constructors](https://github.com/dotnet/csharplang/issues/2691) | [primary-constructors](https://github.com/dotnet/roslyn/tree/features/primary-constructors) | [In Progress](https://github.com/dotnet/roslyn/issues/57048) | TBD | TBD | [MadsTorgersen](https://github.com/MadsTorgersen) |
| [Params Span\<T> + Stackalloc any array type](https://github.com/dotnet/csharplang/issues/1757) | [params-span](https://github.com/dotnet/roslyn/tree/features/params-span) | [In Progress](https://github.com/dotnet/roslyn/issues/57049) | [cston](https://github.com/cston) | TBD | [jaredpar](https://github.com/jaredpar) |
| [nameof accessing instance members](https://github.com/dotnet/roslyn/issues/40229) | main | [In Progress](https://github.com/dotnet/roslyn/pull/48754) | [YairHalberstadt ](https://github.com/YairHalberstadt) | [333fred](https://github.com/333fred), [AlekseyTs](https://github.com/AlekseyTs)  | [333fred](https://github.com/333fred) |
| [Lambda default parameters](https://github.com/dotnet/csharplang/issues/6051) | [lambda-default-parameters](https://github.com/dotnet/roslyn/tree/features/lambda-default-parameters) | [In Progress](https://github.com/dotnet/roslyn/issues/62485) | [adamperlin](https://github.com/adamperlin) | [333fred](https://github.com/333fred), [cston](https://github.com/cston)  | [captainsafia](https://github.com/captainsafia) | 
| [Default in deconstruction](https://github.com/dotnet/roslyn/pull/25562) | [decon-default](https://github.com/dotnet/roslyn/tree/features/decon-default) | [In Progress](https://github.com/dotnet/roslyn/issues/25559) | [jcouv](https://github.com/jcouv) | [gafter](https://github.com/gafter) | [jcouv](https://github.com/jcouv) |
  
# C# 11.0

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [File-local types](https://github.com/dotnet/csharplang/issues/6011) | [file-types](https://github.com/dotnet/roslyn/tree/features/file-types) | [Merged into 17.4p1](https://github.com/dotnet/roslyn/issues/60819) | [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv), [cston](https://github.com/cston)  | [stephentoub](https://github.com/stephentoub) | 
| [ref fields](https://github.com/dotnet/csharplang/blob/main/proposals/low-level-struct-improvements.md) | [ref-fields](https://github.com/dotnet/roslyn/tree/features/ref-fields) | [Merged into 17.3p3](https://github.com/dotnet/roslyn/issues/59194) | [cston](https://github.com/cston) | [RikkiGibson](https://github.com/RikkiGibson), [AlekseyTs](https://github.com/AlekseyTs) | [jaredpar](https://github.com/jaredpar) | 
| [Required members](https://github.com/dotnet/csharplang/issues/3630) | main | [Merged into 17.3p2](https://github.com/dotnet/roslyn/issues/57046) | [333fred](https://github.com/333fred) | [jcouv](https://github.com/jcouv), [RikkiGibson](https://github.com/RikkiGibson) | [333fred](https://github.com/333fred) |
| [DIM for Static Members](https://github.com/dotnet/csharplang/issues/4436) | [DefaultInterfaceImplementation](https://github.com/dotnet/roslyn/tree/features/DefaultInterfaceImplementation) | [Merged into 17.3p2](https://github.com/dotnet/roslyn/issues/60968) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [jcouv](https://github.com/jcouv)  | [MadsTorgersen](https://github.com/MadsTorgersen) | 
| [Numeric IntPtr](https://github.com/dotnet/csharplang/issues/6065) | [numeric-intptr](https://github.com/dotnet/roslyn/tree/features/numeric-intptr) | [Merged into 17.3p2](https://github.com/dotnet/roslyn/issues/60578) | [jcouv](https://github.com/jcouv) | [cston](https://github.com/cston), [333fred](https://github.com/333fred) | [jcouv](https://github.com/jcouv) | 
| [Unsigned Right Shift](https://github.com/dotnet/csharplang/issues/4682) | [UnsignedRightShift](https://github.com/dotnet/roslyn/tree/features/UnsignedRightShift) | [Merged into 17.3p1](https://github.com/dotnet/roslyn/issues/60433) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [jcouv](https://github.com/jcouv)  | [AlekseyTs](https://github.com/AlekseyTs) | 
| [Utf8 String Literals](https://github.com/dotnet/csharplang/issues/184) | [Utf8StringLiterals](https://github.com/dotnet/roslyn/tree/features/Utf8StringLiterals) | [Merged into 17.3p1](https://github.com/dotnet/roslyn/issues/58848) | [AlekseyTs](https://github.com/AlekseyTs) | [cston](https://github.com/cston), [RikkiGibson](https://github.com/RikkiGibson) | [MadsTorgersen](https://github.com/MadsTorgersen) |
| [Pattern matching on `ReadOnlySpan<char>`](https://github.com/dotnet/csharplang/issues/1881) | [patterns-span-char](https://github.com/dotnet/roslyn/tree/features/patterns-span-char) | [Merged into 17.3p1](https://github.com/dotnet/roslyn/issues/59191) | [YairHalberstadt ](https://github.com/YairHalberstadt) | [cston](https://github.com/cston), [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv) |
| [Checked Operators](https://github.com/dotnet/csharplang/issues/4665) | [CheckedUserDefinedOperators](https://github.com/dotnet/roslyn/tree/features/CheckedUserDefinedOperators) | [Merged into 17.3p1](https://github.com/dotnet/roslyn/issues/59458) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [chsienki](https://github.com/chsienki) | [AlekseyTs](https://github.com/AlekseyTs) | 
| [auto-default structs](https://github.com/dotnet/csharplang/issues/5737) | main | [Merged into 17.3p1](https://github.com/dotnet/roslyn/issues/60167) | [RikkiGibson](https://github.com/RikkiGibson) | [cston](https://github.com/cston), [jcouv](https://github.com/jcouv) | 
| [Newlines in interpolations](https://github.com/dotnet/csharplang/issues/4935) | main | [Merged in 17.1p1](https://github.com/dotnet/roslyn/issues/57154) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) | [jcouv](https://github.com/jcouv), [chsienki](https://github.com/chsienki) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) |
| [List patterns](https://github.com/dotnet/csharplang/issues/3435) | [list-patterns](https://github.com/dotnet/roslyn/tree/features/list-patterns) | [Merged in 17.1p2](https://github.com/dotnet/roslyn/issues/51289) | [alrz](https://github.com/alrz) | [jcouv](https://github.com/jcouv), [333fred](https://github.com/333fred) | [333fred](https://github.com/333fred) |
| [Raw string literals](https://github.com/dotnet/csharplang/issues/4304) | [RawStringLiterals](https://github.com/dotnet/roslyn/tree/features/RawStringLiterals) | [Merged into 17.2](https://github.com/dotnet/roslyn/issues/55306) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) | [jcouv](https://github.com/jcouv) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) |
| [Cache delegates for static method group](https://github.com/dotnet/roslyn/issues/5835) | main | [Merged into 17.2](https://github.com/dotnet/roslyn/pull/58288) | [pawchen](https://github.com/pawchen) | [AlekseyTs](https://github.com/AlekseyTs), [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs) |
| [nameof(parameter)](https://github.com/dotnet/csharplang/issues/373) | main | [Merged into 17.3p2](https://github.com/dotnet/roslyn/issues/40524) | [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs), [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv) |
| [Relaxing Shift Operator](https://github.com/dotnet/csharplang/issues/4666) | main | [Merged into 17.3p2](https://github.com/dotnet/roslyn/issues/60967) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [jcouv](https://github.com/jcouv)  | [MadsTorgersen](https://github.com/MadsTorgersen) | 
| [Generic attributes](https://github.com/dotnet/csharplang/issues/124) | [generic-attributes](https://github.com/dotnet/roslyn/tree/features/generic-attributes) | [Merged into 17.0p4](https://github.com/dotnet/roslyn/issues/36285) | [AviAvni](https://github.com/AviAvni) | [RikkiGibson](https://github.com/RikkiGibson), [jcouv](https://github.com/jcouv) | [mattwar](https://github.com/mattwar) |
  
# C# 10.0

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [Record structs](https://github.com/dotnet/csharplang/issues/4334) | [record-structs](https://github.com/dotnet/roslyn/tree/features/record-structs) | [Merged into 16.11](https://github.com/dotnet/roslyn/issues/51199) | [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs), [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv) |
| [Global Using Directive](https://github.com/dotnet/csharplang/issues/3428) | [GlobalUsingDirective](https://github.com/dotnet/roslyn/tree/features/GlobalUsingDirective) | [Merged into 16.11](https://github.com/dotnet/roslyn/issues/51307) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [cston](https://github.com/cston) | [AlekseyTs](https://github.com/AlekseyTs) |
| [Improved Definite Assignment](https://github.com/dotnet/csharplang/issues/4465) | [improved-definite-assignment](https://github.com/dotnet/roslyn/tree/features/improved-definite-assignment) | [Merged into 17.0](https://github.com/dotnet/roslyn/issues/51463) | [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv) | [jaredpar](https://github.com/jaredpar) |
| [Constant Interpolated Strings](https://github.com/dotnet/csharplang/issues/2951) | main | [Merged into 16.9p3](https://github.com/dotnet/roslyn/pull/49676)  | [kevinsun-dev](https://github.com/kevinsun-dev) | [333fred](https://github.com/333fred) | [jaredar](https://github.com/jaredpar), [agocke](https://github.com/agocke) |
| [Extended property patterns](https://github.com/dotnet/csharplang/issues/4394) | [extended-property-patterns](https://github.com/dotnet/roslyn/tree/features/extended-property-patterns) | [Merged into 17.0](https://github.com/dotnet/roslyn/issues/52468) | [alrz](https://github.com/alrz) | [jcouv](https://github.com/jcouv), [333fred](https://github.com/333fred) | [333fred](https://github.com/333fred) |
| [Sealed record ToString](https://github.com/dotnet/csharplang/issues/4174) | main | [Merged](https://github.com/dotnet/roslyn/issues/52031) | [thomaslevesque](https://github.com/thomaslevesque/) | [jcouv](https://github.com/jcouv) | [333fred](https://github.com/333fred) |
| [Source Generator V2 APIs](https://github.com/dotnet/roslyn/issues/51257) | [features/source-generators](https://github.com/dotnet/roslyn/tree/features/source-generators) | [Merged into 17.0p2](https://github.com/dotnet/roslyn/issues/51257) | [chsienki](https://github.com/chsienki/) | [rikkigibson](https://github.com/rikkigibson), [jaredpar](https://github.com/jaredpar), [cston](https://github.com/cston) | N/A |
| [Mix declarations and variables in deconstruction](https://github.com/dotnet/csharplang/issues/125) | main | [Merged into 16.10](https://github.com/dotnet/roslyn/issues/47746) | [YairHalberstadt ](https://github.com/YairHalberstadt) | [jcouv](https://github.com/jcouv) | [MadsTorgersen](https://github.com/MadsTorgersen) |
| [Async method builder override](https://github.com/dotnet/csharplang/issues/1407) | main | [Merged into 17.0p2](https://github.com/dotnet/roslyn/issues/51999) | [jcouv](https://github.com/jcouv) | [cston](https://github.com/cston), [RikkiGibson](https://github.com/RikkiGibson) | [stephentoub](https://github.com/stephentoub) |
| [Enhanced `#line` directive](https://github.com/dotnet/csharplang/issues/4747) | main | [Merged into 17.0p2](https://github.com/dotnet/roslyn/issues/54509) | [cston](https://github.com/cston) | [jcouv](https://github.com/jcouv), [RikkiGibson](https://github.com/RikkiGibson) | [MadsTorgersen](https://github.com/MadsTorgersen) |
| [Lambda improvements](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-10.0/lambda-improvements.md) | main | [Merged into 17.0p2](https://github.com/dotnet/roslyn/issues/52192) | [cston](https://github.com/cston) | [333fred](https://github.com/333fred), [jcouv](https://github.com/jcouv) | [jaredpar](https://github.com/jaredpar) |
| [Static Abstract Members In Interfaces C# 10 Preview](https://github.com/dotnet/csharplang/issues/4436) | main | [Merged into 17.0p2](https://github.com/dotnet/roslyn/issues/52221) | [AlekseyTs](https://github.com/AlekseyTs) | [333fred](https://github.com/333fred), [RikkiGibson](https://github.com/RikkiGibson) | [MadsTorgersen](https://github.com/MadsTorgersen) |
| [Interpolated string improvements](https://github.com/dotnet/csharplang/issues/4487) | main | [Merged into 17.0p3](https://github.com/dotnet/roslyn/issues/51499) | [333fred](https://github.com/333fred) | [AlekseyTs](https://github.com/AlekseyTs), [chsienki](https://github.com/chsienki) | [jaredpar](https://github.com/jaredpar) |
| [File-scoped namespace](https://github.com/dotnet/csharplang/issues/137) | main | [Merged into 17.0p3](https://github.com/dotnet/roslyn/issues/49000) | [RikkiGibson](https://github.com/RikkiGibson) | [jcouv](https://github.com/jcouv), [chsienki](https://github.com/chsienki) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi) |
| [Parameterless struct constructors](https://github.com/dotnet/csharplang/issues/99) | [struct-ctors](https://github.com/dotnet/roslyn/tree/features/struct-ctors) | [Merged into 17.0p3](https://github.com/dotnet/roslyn/issues/51698) | [cston](https://github.com/cston) | [jcouv](https://github.com/jcouv), [333fred](https://github.com/333fred) | [jcouv](https://github.com/jouv) |
| [Caller expression attribute](https://github.com/dotnet/csharplang/issues/287) | main | [Merged into 17.0p3](https://github.com/dotnet/roslyn/issues/52745) | [Youssef1313](https://github.com/Youssef1313) | [333fred](https://github.com/333fred),[AlekseyTs](https://github.com/AlekseyTs) | [jcouv](https://github.com/jcouv) |

# VB 17.0

| Feature                                                                                   | Branch | State                                                            | Developer                                 | Reviewer                          | LDM Champ |
|-------------------------------------------------------------------------------------------|--------|------------------------------------------------------------------|-------------------------------------------|-----------------------------------|-----------|
| [Caller expression attribute](https://github.com/dotnet/csharplang/issues/287) | main | [Merged into 17.0p3](https://github.com/dotnet/roslyn/issues/52745) | [Youssef1313](https://github.com/Youssef1313) | [333fred](https://github.com/333fred),[AlekseyTs](https://github.com/AlekseyTs) | [jcouv](https://github.com/jcouv) |

# VB 16.9

| Feature                                                                                   | Branch | State                                                            | Developer                                 | Reviewer                          | LDM Champ |
|-------------------------------------------------------------------------------------------|--------|------------------------------------------------------------------|-------------------------------------------|-----------------------------------|-----------|
| [Enable consumption of init-only properties](https://github.com/dotnet/roslyn/pull/50414) | main | [Merged (16.9p3)](https://github.com/dotnet/roslyn/issues/50792) | [AlekseyTs](https://github.com/AlekseyTs) | [jcouv](https://github.com/jcouv) | N/A       |

# C# 9

| Feature                                                                                            | Branch                                                                                                         | State                                                        | Developer                                                                    | Reviewer                                                                           | LDM Champ                               |
|----------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------|------------------------------------------------------------------------------|------------------------------------------------------------------------------------|-----------------------------------------|
| [Target-typed new](https://github.com/dotnet/csharplang/issues/100)                                | [target-typed-new](https://github.com/dotnet/roslyn/tree/features/target-typed-new)                            | [Merged into 16.7p1](https://github.com/dotnet/roslyn/issues/28489)   | [alrz](https://github.com/alrz)                                     | [jcouv](https://github.com/jcouv)                                                  | [jcouv](https://github.com/jcouv)       |
| [Skip locals init](https://github.com/dotnet/csharplang/issues/1738)                               | [localsinit](https://github.com/dotnet/roslyn/tree/features/localsinit)                                        | [Merged](https://github.com/dotnet/roslyn/issues/25780) | [t-camaia](https://github.com/t-camaia), [agocke](https://github.com/agocke)      | [jaredpar](https://github.com/jaredpar)                                            | [agocke](https://github.com/agocke)     |
| [Lambda discard parameters](https://github.com/dotnet/csharplang/issues/111)                       | main                                                                                                         | [Merged](https://github.com/dotnet/roslyn/issues/38820)      | [jcouv](https://github.com/jcouv)                                            | [AlekseyTs](https://github.com/AlekseyTs), [chsienki](https://github.com/chsienki) | [jcouv](https://github.com/jcouv)       |
| [Native ints](https://github.com/dotnet/csharplang/issues/435)                                     | [features/NativeInt](https://github.com/dotnet/roslyn/tree/features/NativeInt)                                 | [Merged into 16.7p1](https://github.com/dotnet/roslyn/issues/38821) | [cston](https://github.com/cston)                                     | [333fred](https://github.com/333fred), [gafter](https://github.com/gafter)         | [jaredpar](https://github.com/jaredpar) |
| [Attributes on local functions](https://github.com/dotnet/csharplang/issues/1888)                  | [features/local-function-attributes](https://github.com/dotnet/roslyn/tree/features/local-function-attributes) | [Merged](https://github.com/dotnet/roslyn/issues/38801) | [RikkiGibson](https://github.com/RikkiGibson)                                     | [agocke](https://github.com/agocke)                                                | [agocke](https://github.com/agocke)     |
| [Function pointers](https://github.com/dotnet/csharplang/issues/191)                               | [function-pointers](https://github.com/dotnet/roslyn/tree/features/function-pointers)                          | [Merged into 16.7p3](https://github.com/dotnet/roslyn/issues/43321) | [333fred](https://github.com/333fred)                                        | [AlekseyTs](https://github.com/AlekseyTs)                                          | [jaredpar](https://github.com/jaredpar) |
| [Pattern matching improvements](https://github.com/dotnet/csharplang/issues/2850)                  | main                                | [Merged into 16.7p1](https://github.com/dotnet/roslyn/issues/40727)                        | [gafter](https://github.com/gafter)                                                | [RikkiGibson](https://github.com/RikkiGibson),[agocke](https://github.com/agocke)  | [gafter](https://github.com/gafter)     |
| [Static lambdas](https://github.com/dotnet/csharplang/issues/275)                                  | [features/static-lambdas](https://github.com/dotnet/roslyn/tree/features/static-lambdas)                       | [Merged in 16.7p4](https://github.com/dotnet/roslyn/issues/39606) | [CyrusNajmabadi](https://github.com/CyrusNajmabadi)                          | [jcouv](https://github.com/jcouv)                                                  | [jcouv](https://github.com/jcouv)       |
| [Records](https://github.com/dotnet/csharplang/issues/39)                                          | [features/records](https://github.com/dotnet/roslyn/tree/features/records)                                     | [Merged into 16.7p3](https://github.com/dotnet/roslyn/issues/40726) | [agocke](https://github.com/agocke)                                          | [gafter](https://github.com/gafter), [333fred](https://github.com/333fred)         | [agocke](https://github.com/agocke)     |
| [Target-typed conditional](https://github.com/dotnet/csharplang/issues/2460)                       | [features/target-typing](https://github.com/dotnet/roslyn/tree/features/target-typing)                         | [Merged into 16.7p4](https://github.com/dotnet/roslyn/issues/43186) | [gafter](https://github.com/gafter)                                          | [agocke](https://github.com/agocke), [RikkiGibson](https://github.com/RikkiGibson) | [gafter](https://github.com/gafter) |
| [Covariant](https://github.com/dotnet/csharplang/issues/49) [Returns](https://github.com/dotnet/csharplang/issues/2844) | [features/covariant-returns](https://github.com/dotnet/roslyn/tree/features/covariant-returns) | [Merged into 16.8p2](https://github.com/dotnet/roslyn/issues/43188) | [gafter](https://github.com/gafter)                                     | [AlekseyTs](https://github.com/AlekseyTs), [agocke](https://github.com/agocke)                                                                            | [gafter](https://github.com/gafter) |
| [Extension GetEnumerator](https://github.com/dotnet/csharplang/issues/3194)                        | [features/extension-foreach](https://github.com/dotnet/roslyn/tree/features/extension-foreach)                 | [Merged into 16.8p2](https://github.com/dotnet/roslyn/issues/43184) | [YairHalberstadt](https://github.com/YairHalberstadt)                        | [333fred](https://github.com/333fred)                                              | [333fred](https://github.com/333fred) |
| [Module initializers](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/module-initializers.md) | [features/module-initializers](https://github.com/dotnet/roslyn/tree/features/module-initializers)                                                                                    | [Merged in 16.7p4](https://github.com/dotnet/roslyn/issues/40500)                                         | [RikkiGibson](https://github.com/RikkiGibson) [jnm2](https://github.com/jnm2)| [AlekseyTs](https://github.com/AlekseyTs)                                          | [gafter](https://github.com/gafter) |
| [Extending Partial](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/extending-partial-methods.md) | [features/partial-methods](https://github.com/dotnet/roslyn/tree/features/partial-methods)       | [Merged into 16.7p2](https://github.com/dotnet/roslyn/issues/43795) | [RikkiGibson](https://github.com/RikkiGibson)                                | [chsienki](https://github.com/chsienki)                                            | [jaredpar](https://github.com/jaredpar) |
| [Top-level statements](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/top-level-statements.md) | [features/SimplePrograms](https://github.com/dotnet/roslyn/tree/features/SimplePrograms)       | [Merged into 16.7p3](https://github.com/dotnet/roslyn/issues/43563)                                                  | [AlekseyTs](https://github.com/AlekseyTs)                                | [cston](https://github.com/cston), [RikkiGibson](https://github.com/RikkiGibson)                                            | [MadsTorgersen](https://github.com/MadsTorgersen) |

# C# 8.0

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [Default Interface Methods](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/default-interface-methods.md) | main | [Merged to dev16.1 preview2](https://github.com/dotnet/roslyn/issues/19217) | [AlekseyTs](https://github.com/AlekseyTs) | [gafter](https://github.com/gafter) | [gafter](https://github.com/gafter) |
| [Nullable reference type](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/nullable-reference-types-specification.md) | main | [Merged to dev16.0 preview1](https://github.com/dotnet/roslyn/issues/22152) | [cston](https://github.com/cston), [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs), [333fred](https://github.com/333fred) | [mattwar](https://github.com/mattwar) |
| [Recursive patterns](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/patterns.md) | main | [Merged to dev16.0 preview2](https://github.com/dotnet/roslyn/issues/25935) | [gafter](https://github.com/gafter) | [agocke](https://github.com/agocke), [cston](https://github.com/cston) | [gafter](https://github.com/gafter) |
| [Async streams](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/async-streams.md) | main | [Merged to dev16.0 preview1](https://github.com/dotnet/roslyn/issues/24037) | [jcouv](https://github.com/jcouv) |  [agocke](https://github.com/agocke) | [stephentoub](https://github.com/stephentoub) |
| [Enhanced using](https://github.com/dotnet/csharplang/issues/1623) | main | [Merged to dev16.0 preview2](https://github.com/dotnet/roslyn/issues/28588) | [chsienki](https://github.com/chsienki) | [agocke](https://github.com/agocke) | [jaredpar](https://github.com/jaredpar) |
| [Ranges](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/ranges.md) | main | [Merged to dev16.0 preview1](https://github.com/dotnet/roslyn/issues/23205) | [agocke](https://github.com/agocke) | [cston](https://github.com/cston) | [jaredpar](https://github.com/jaredpar) |
| [Null-coalescing Assignment](https://github.com/dotnet/csharplang/issues/34) | main | [Merged to dev16.0 preview1](https://github.com/dotnet/roslyn/issues/29168) | [333fred](https://github.com/333fred) | [cston](https://github.com/cston) | [gafter](https://github.com/gafter)
| [Alternative interpolated verbatim strings](https://github.com/dotnet/csharplang/issues/1630) | main | Merged to dev16.0 preview1 | [jcouv](https://github.com/jcouv) | [cston](https://github.com/cston) | [jcouv](https://github.com/jcouv)
| [stackalloc in nested contexts](https://github.com/dotnet/csharplang/issues/1412) | main | Merged to dev16.2 preview1 | [gafter](https://github.com/gafter) | - | [gafter](https://github.com/gafter)
| [Unmanaged generic structs](https://github.com/dotnet/csharplang/issues/1744) | main | [Merged to dev16.1 preview1](https://github.com/dotnet/roslyn/issues/31374) | [RikkiGibson](https://github.com/RikkiGibson) | - | [jaredpar](https://github.com/jaredpar) |
| [Static local functions](https://github.com/dotnet/csharplang/issues/1565) | main | [Merged in dev16.0 preview2](https://github.com/dotnet/roslyn/issues/32069) | [cston](https://github.com/cston) | [jaredpar](https://github.com/jaredpar) | [jcouv](https://github.com/jcouv)
| [Readonly members](https://github.com/dotnet/csharplang/issues/1710) | main | [Merged to dev16.1 preview2](https://github.com/dotnet/roslyn/issues/32911) | [RikkiGibson](https://github.com/RikkiGibson) | TBD | [jaredpar](https://github.com/jaredpar)

# VB 16.0

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [Line continuation comments](https://github.com/dotnet/vblang/issues/65) | [continuation-comments](https://github.com/dotnet/roslyn/tree/features/continuation-comments) | Merged in 16.1 (preview2) | [paul1956](https://github.com/paul1956) | [AlekseyTs](https://github.com/AlekseyTs) | [gafter](https://github.com/gafter) |
| [Relax null-coalescing operator requirements](https://github.com/dotnet/vblang/issues/339) | [null-operator-enhancements](https://github.com/dotnet/roslyn/tree/features/null-operator-enhancements) | Merged in 16.0 | [333fred](https://github.com/333fred) | [cston](https://github.com/cston) | [gafter](https://github.com/gafter) |

# C# 7.3

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [blittable](https://github.com/dotnet/csharplang/pull/206) | None | Merged | None | - | [jaredpar](https://github.com/jaredpar) |
| [Support == and != for tuples](https://github.com/dotnet/csharplang/issues/190) | [tuple-equality](https://github.com/dotnet/roslyn/tree/features/tuple-equality) | Merged | [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs) | [jcouv](https://github.com/jcouv) |
| strongname | main | Merged | [tyoverby](https://github.com/tyoverby) | [agocke](https://github.com/agocke) | [jaredpar](https://github.com/jaredpar) |
| [Attribute on backing field](https://github.com/dotnet/csharplang/issues/42) | features/compiler | Merged | [jcouv](https://github.com/jcouv) | [AlekseyTs](https://github.com/AlekseyTs) | [jcouv](https://github.com/jcouv) |
| Ref Reassignment | [ref-reassignment](https://github.com/dotnet/roslyn/tree/features/ref-reassignment) | Merged | [agocke](https://github.com/agocke) | [vsadov](https://github.com/vsadov) | [gafter](https://github.com/gafter) |
| Constraints | [constraints](https://github.com/dotnet/roslyn/tree/features/constraints) | Merged | [OmarTawfik](https://github.com/OmarTawfik) | [vsadov](https://github.com/vsadov) | [gafter](https://github.com/gafter) |
| [Stackalloc initializers](https://github.com/dotnet/csharplang/issues/1286) | [stackalloc-init](https://github.com/dotnet/roslyn/tree/features/stackalloc-init) | Merged | [alrz](https://github.com/alrz) | [vsadov](https://github.com/vsadov) | [jcouv](https://github.com/jcouv) |
| [Custom fixed](https://github.com/dotnet/csharplang/issues/1314) | [custom-fixed](https://github.com/dotnet/roslyn/tree/features/custom-fixed) | Merged | [vsadov](https://github.com/vsadov) | [jcouv](https://github.com/jcouv) | [jarepdar](https://github.com/jaredpar) |
| [Indexing movable fixed buffers](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.3/indexing-movable-fixed-fields.md) | - | Merged | [vsadov](https://github.com/vsadov) | [jcouv](https://github.com/jcouv) | [jarepdar](https://github.com/jaredpar) |
| [Improved overload candidates](https://github.com/dotnet/csharplang/issues/98) | features/compiler | Merged | [gafter](https://github.com/gafter) | [cston](https://github.com/cston) | [mattwar](https://github.com/mattwar) |
| [Expression variables](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.3/expression-variables-in-initializers.md) | [features/ExpressionVariables](https://github.com/dotnet/roslyn/tree/features/ExpressionVariables) | Merged | [AlekseyTs](https://github.com/AlekseyTs) | [gafter](https://github.com/gafter) | [AlekseyTs](https://github.com/AlekseyTs) |

# C# 7.2 fixes

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [`ref` and `this` ordering in ref extension](https://github.com/dotnet/roslyn/pull/23643) | - | Merged | [alrz](https://github.com/alrz) | - | - |
| [Tiebreaker for by-val and `in` overloads](https://github.com/dotnet/roslyn/pull/23122) | main | Merged | [OmarTawfik](https://github.com/OmarTawfik) | - | - |

# C# 7.2

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [ref readonly](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.2/readonly-ref.md) | main | Merged | [vsadov](https://github.com/vsadov), [OmarTawfik](https://github.com/OmarTawfik) | [cston](https://github.com/cston),[gafter](https://github.com/gafter) | [jaredpar](https://github.com/jaredpar) |
| [interior pointer/Span<T>/ref struct](https://github.com/dotnet/csharplang/pull/264) | main | Merged | [vsadov](https://github.com/vsadov) | [gafter](https://github.com/gafter), [jaredpar](https://github.com/jaredpar) | [jaredpar](https://github.com/jaredpar) |
| [non-trailing named arguments](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.2/non-trailing-named-arguments.md) | main | Merged | [jcouv](https://github.com/jcouv) | [gafter](https://github.com/gafter) | [jcouv](https://github.com/jcouv) |
| [private protected](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.2/private-protected.md) | main | Merged | [gafter](https://github.com/gafter) | [jcouv](https://github.com/jcouv) | [gafter](https://github.com/gafter) |
| [conditional ref operator](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.2/conditional-ref.md) | main | Merged | [vsadov](https://github.com/vsadov) | [cston](https://github.com/cston) | [jaredpar](https://github.com/jaredpar) |
| [Digit separator after base specifier](https://github.com/dotnet/roslyn/pull/20449) | main | Merged | [alrz](https://github.com/alrz) | - | [gafter](https://github.com/gafter) |

# C# 7.1

| Feature | Branch | State | Developer | Reviewer | LDM Champ |
| ------- | ------ | ----- | --------- | -------- | --------- |
| [Async Main](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.1/async-main.md) | main | Merged | [tyoverby](https://github.com/tyoverby) | [vsadov](https://github.com/vsadov) | [stephentoub](https://github.com/stephentoub) |
| [Default Expressions](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.1/target-typed-default.md) | main  | Merged | [jcouv](https://github.com/jcouv) | [cston](https://github.com/cston) | [jcouv](https://github.com/jcouv) |
| [Ref Assemblies](https://github.com/dotnet/roslyn/blob/main/docs/features/refout.md) | main | Merged (IDE and project-system integrations ongoing) | [jcouv](https://github.com/jcouv) | [gafter](https://github.com/gafter) | N/A |
| [Infer tuple names](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.1/infer-tuple-names.md) | main | Merged | [jcouv](https://github.com/jcouv) | [gafter](https://github.com/gafter) | [jcouv](https://github.com/jcouv) |
| [Pattern-matching with generics](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-7.1/generics-pattern-match.md) | main  | Merged | [gafter](https://github.com/gafter) | [agocke](https://github.com/agocke) | [gafter](https://github.com/gafter) |

# FAQ

- **Is target version a guarantee?**: No.  It's explicitly not a guarantee.  This is just the planned and ongoing work to the best of our knowledge at this time.
- **Where are these State values defined?**: Take a look at the [Developing a Language Feature](contributing/Developing%20a%20Language%20Feature.md) document.