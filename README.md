# ResearchNotes-Demo
Research Notes &amp; demo
Lib.Harmony - 一个用于在运行时修补、替换和装饰 .NET 方法的库。它允许不修改原先代码方法，以少数基于反射的声名，注解方式实现修改原有功能。

Lib.Harmony 适用于所有编译为CIL（微软的中间字节码语言）的语言。

但是该技术可以与任何.NET版本一起使用。它还照顾对同一方法的多次更改（它们累积而不是覆盖）。

1）最新2.0版本终于支持.net core。

2)Harmony支持手动（Patch）和自动（PatchAll）织入。

3)位置可以是执行前（Prefix）、执行后（Postfix）和终结嚣（Finalizer），也可以更详细的手动修改IL（Transpiler）。

4）Getter/Setter、虚/ 非虚 方法、 静态 方法。
