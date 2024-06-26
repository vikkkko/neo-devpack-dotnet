using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Attributes;

namespace Neo.Compiler.CSharp.UnitTests.TestClasses;

[ContractPermission(Permission.WildCard, "c")]
[ContractPermission("0x01ff00ff00ff00ff00ff00ff00ff00ff00ff00a4", "a", "b")]
[ContractPermission("0x01ff00ff00ff00ff00ff00ff00ff00ff00ff00a4")]
[ContractPermission("0x01ff00ff00ff00ff00ff00ff00ff00ff00ff00a4", Permission.WildCard)]
[ContractPermission("0x01ff00ff00ff00ff00ff00ff00ff00ff00ff00a4", "*")]
[ContractPermission("0x01ff00ff00ff00ff00ff00ff00ff00ff00ff00a4", "a")]
[ContractPermission("*", "a")]
[ContractPermission("*", "*")]
[ContractPermission("*", "b")]
[ContractTrust("0x0a0b00ff00ff00ff00ff00ff00ff00ff00ff00a4")]
public class Contract_ABIAttributes2 : SmartContract.Framework.SmartContract
{
    public static int test() => 0;
}
