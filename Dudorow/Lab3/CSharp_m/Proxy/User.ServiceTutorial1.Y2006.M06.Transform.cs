//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("0.0.0.0")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Transform, SourceAssemblyKey="User.ServiceTutorial1.Y2006.M06, Version=0.0.0.0, Culture=neutral, PublicKeyToken" +
    "=9425fde5d986f051")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Dss.Transforms.TransformUser {
    
    
    public class Transforms : global::Microsoft.Dss.Core.Transforms.TransformBase {
        
        static Transforms() {
            Register();
        }
        
        public static void Register() {
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State), new global::Microsoft.Dss.Core.Attributes.Transform(RoboticsServiceTutorial1_Proxy_ServiceTutorial1State_TO_RoboticsServiceTutorial1_ServiceTutorial1State));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::RoboticsServiceTutorial1.ServiceTutorial1State), new global::Microsoft.Dss.Core.Attributes.Transform(RoboticsServiceTutorial1_ServiceTutorial1State_TO_RoboticsServiceTutorial1_Proxy_ServiceTutorial1State));
        }
        
        public static object RoboticsServiceTutorial1_Proxy_ServiceTutorial1State_TO_RoboticsServiceTutorial1_ServiceTutorial1State(object transformFrom) {
            global::RoboticsServiceTutorial1.ServiceTutorial1State target = new global::RoboticsServiceTutorial1.ServiceTutorial1State();
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State from = ((global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State)(transformFrom));
            target.Member = from.Member;
            return target;
        }
        
        public static object RoboticsServiceTutorial1_ServiceTutorial1State_TO_RoboticsServiceTutorial1_Proxy_ServiceTutorial1State(object transformFrom) {
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State target = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            global::RoboticsServiceTutorial1.ServiceTutorial1State from = ((global::RoboticsServiceTutorial1.ServiceTutorial1State)(transformFrom));
            target.Member = from.Member;
            return target;
        }
    }
}
