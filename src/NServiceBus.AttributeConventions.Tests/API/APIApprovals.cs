using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using PublicApiGenerator;
using System.Runtime.CompilerServices;

namespace NServiceBus.AttributeConventions.Tests.API
{
    public class APIApprovals
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Approve_API()
        {
            var publicApi = typeof(EndpointConfigurationAttributeConventionsExtensions).Assembly.GeneratePublicApi(new ApiGeneratorOptions()
            {
                ExcludeAttributes =
                [
                    "System.Runtime.Versioning.TargetFrameworkAttribute"
                ]
            });

            Approvals.Verify(publicApi.Replace(".git", ""));
        }
    }
}
