﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class BaseServiceException : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Net;\r\nusing System" +
                    ".Text;\r\n\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    ///<summary>\r\n    /// Common exception for the ");
            
            #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" service.\r\n    /// </summary>\r\n#if !NETSTANDARD\r\n    [Serializable]\r\n#endif\r\n    " +
                    "public partial class Amazon");
            
            #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception : AmazonServiceException\r\n    {\r\n        /// <summary>\r\n        /// Con" +
                    "struct instance of Amazon");
            
            #line 27 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception\r\n        /// </summary>\r\n        /// <param name=\"message\"></param>\r\n  " +
                    "      public Amazon");
            
            #line 30 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception(string message)\r\n            : base(message)\r\n        {\r\n        }\r\n\r\n " +
                    "       /// <summary>\r\n        /// Construct instance of Amazon");
            
            #line 36 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception\r\n        /// </summary>\r\n        /// <param name=\"message\"></param>\r\n  " +
                    "      /// <param name=\"innerException\"></param>\r\n        public Amazon");
            
            #line 40 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception(string message, Exception innerException)\r\n            : base(message, " +
                    "innerException)\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Cons" +
                    "truct instance of Amazon");
            
            #line 46 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception\r\n        /// </summary>\r\n        /// <param name=\"innerException\"></par" +
                    "am>\r\n        public Amazon");
            
            #line 49 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception(Exception innerException)\r\n            : base(innerException.Message, i" +
                    "nnerException)\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Const" +
                    "ruct instance of Amazon");
            
            #line 55 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Exception
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public Amazon");
            
            #line 62 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Exception(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct instance of Amazon");
            
            #line 68 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Exception
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""innerException""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public Amazon");
            
            #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Exception(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the Amazon");
            
            #line 83 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Exception class with serialized data.
        /// </summary>
        /// <param name=""info"">The <see cref=""T:System.Runtime.Serialization.SerializationInfo"" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name=""context"">The <see cref=""T:System.Runtime.Serialization.StreamingContext"" /> that contains contextual information about the source or destination.</param>
        /// <exception cref=""T:System.ArgumentNullException"">The <paramref name=""info"" /> parameter is null. </exception>
        /// <exception cref=""T:System.Runtime.Serialization.SerializationException"">The class name is null or <see cref=""P:System.Exception.HResult"" /> is zero (0). </exception>
        protected Amazon");
            
            #line 89 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Ser" +
                    "ialization.StreamingContext context)\r\n            : base(info, context)\r\n       " +
                    " {\r\n        }\r\n#endif\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
