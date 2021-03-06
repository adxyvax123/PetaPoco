// <copyright company="PetaPoco - CollaboratingPlatypus">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>PetaPoco - CollaboratingPlatypus</author>
// <date>2016/01/29</date>

using PetaPoco.Tests.Integration.Databases;
using Xunit;

namespace PetaPoco.Tests.Integration.x86.Databases.MSAccess
{
    [Collection("MSAccessTests")]
    public class MsAccessDatabaseTests : BaseDatabaseTests
    {
        public MsAccessDatabaseTests()
            : base(new MsAccessDBTestProvider())
        {
        }

        public override void BeginTransaction_WhenIsolationLevelIsSet_ShouldBeOfIsolationLevel()
        {
            // Not supported by provider.
        }
    }
}