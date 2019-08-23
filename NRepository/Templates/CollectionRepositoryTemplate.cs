﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Версия среды выполнения: 16.0.0.0
//  
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NRepository.Templates
{
    using System.Text;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CollectionRepositoryTemplate : CollectionRepositoryTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System.Linq;\r\n\r\nnamespace NRepository.Samples.Collections.Repositories\r\n{\r\n" +
                    "\tpublic class ");
            
            #line 9 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Name));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 9 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Interface));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tpublic ");
            
            #line 11 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Name));
            
            #line default
            #line hidden
            this.Write("(NRepository.Core.CollectionRepositorySource<");
            
            #line 11 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write("> repositorySource)\r\n\t\t{\r\n\t\t\tRepositorySource = repositorySource;\r\n\t\t}\r\n\r\n\t\tpubli" +
                    "c NRepository.Core.CollectionRepositorySource<");
            
            #line 16 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write("> RepositorySource { get; private set; }\r\n\r\n\t\t");
            
            #line 18 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 if(Params.Contract.IsSelect) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 19 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write(" Select(");
            
            #line 19 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyType));
            
            #line default
            #line hidden
            this.Write(" key)\r\n\t\t{\r\n\t\t\treturn Enumerable.FirstOrDefault(RepositorySource.Collection, t =>" +
                    " t.");
            
            #line 21 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(" == key);\r\n\t\t}\r\n\r\n\t\tpublic ");
            
            #line 24 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write("[] Select()\r\n\t\t{\r\n\t\t\treturn Enumerable.ToArray(RepositorySource.Collection);\r\n\t\t}" +
                    "\r\n\t\t");
            
            #line 28 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 30 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 if(Params.Contract.IsDelete) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic void Delete(");
            
            #line 31 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyType));
            
            #line default
            #line hidden
            this.Write(" key)\r\n\t\t{\r\n\t\t\tvar item = Enumerable.FirstOrDefault(RepositorySource.Collection, " +
                    "t => t.");
            
            #line 33 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(" == key);\r\n\r\n\t\t\tif(item == null)\r\n\t\t\t\tthrow new System.ArgumentException(\"Model w" +
                    "ith key \" + key + \" not found\");\r\n\r\n\t\t\tRepositorySource.Collection.Remove(item);" +
                    "\r\n\t\t}\r\n\r\n\t\tpublic void Delete(");
            
            #line 41 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write(" model)\r\n\t\t{\r\n\t\t\tDelete(model.");
            
            #line 43 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\t\t");
            
            #line 45 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 47 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 if(Params.Contract.IsCreate) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 48 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyType));
            
            #line default
            #line hidden
            this.Write(" Create(");
            
            #line 48 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write(" model)\r\n\t\t{\r\n\t\t\tvar item = Enumerable.FirstOrDefault(RepositorySource.Collection" +
                    ", t => t.");
            
            #line 50 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(" == model.");
            
            #line 50 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\tif(item != null)\r\n\t\t\t\tthrow new System.ArgumentException(\"Model with key" +
                    " \" + item.");
            
            #line 53 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(" + \" already exist\");\r\n\r\n\t\t\tRepositorySource.Collection.Add(model);\r\n\r\n\t\t\treturn " +
                    "model.");
            
            #line 57 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t}\r\n\t\t");
            
            #line 59 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 61 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 if(Params.Contract.IsUpdate) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 62 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyType));
            
            #line default
            #line hidden
            this.Write(" Update(");
            
            #line 62 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.FullNameModel));
            
            #line default
            #line hidden
            this.Write(" model)\r\n\t\t{\r\n\t\t\tDelete(model.");
            
            #line 64 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.KeyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\treturn Create(model);\r\n\t\t}\r\n\t\t");
            
            #line 68 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\Robert Horvald\Documents\NRepository\NRepository\Templates\CollectionRepositoryTemplate.tt"

private global::NRepository.Params.CollectionRepositoryTemplateParams _ParamsField;

/// <summary>
/// Access the Params parameter of the template.
/// </summary>
private global::NRepository.Params.CollectionRepositoryTemplateParams Params
{
    get
    {
        return this._ParamsField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool ParamsValueAcquired = false;
if (this.Session.ContainsKey("Params"))
{
    this._ParamsField = ((global::NRepository.Params.CollectionRepositoryTemplateParams)(this.Session["Params"]));
    ParamsValueAcquired = true;
}
if ((ParamsValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Params");
    if ((data != null))
    {
        this._ParamsField = ((global::NRepository.Params.CollectionRepositoryTemplateParams)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class CollectionRepositoryTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
