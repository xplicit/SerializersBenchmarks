﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SerializersBenchmarks.Templates {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using SerializersBenchmarks;
    using SerializersBenchmarks.Objects;
    using System;
    
    
    public partial class BenchArrayBase : BenchArrayBaseBase {
        
        
        #line 92 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"

    public virtual void Usings(){}
     
	public virtual string NameSpace {get {return "test";}}

	public virtual BenchTypeInfo[] SerializedTypes {
		get {	
			return new BenchTypeInfo[] {
		 		new BenchTypeInfo(typeof(ByteArray64K),10000),
		 		new BenchTypeInfo(typeof(ByteArray4K),100000),
		 		new BenchTypeInfo(typeof(IntArray64K),250),
		 		new BenchTypeInfo(typeof(LongArray64K),250),
		 		new BenchTypeInfo(typeof(ShortArray64K),250),
		 		new BenchTypeInfo(typeof(PrimitiveType),1000000),
		 		new BenchTypeInfo(typeof(IntList4K),1000)
		 	};
		}
	}

	public virtual void InitializeSerializer(){}

    public virtual void InstantiateSerializer(string name, string type){}

    public virtual void Serialize(string serName, string objName, string objType, string streamName){}

    public virtual void Deserialize(string serName, string objName, string objType, string streamName){}

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 8 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\nusing System;\nusing BenchmarkSuite.Framework;\nusing System.IO;\nusing SerializersBenchmarks;\n");
            
            #line default
            #line hidden
            
            #line 13 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 Usings(); 
            
            #line default
            #line hidden
            
            #line 14 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\nnamespace ");
            
            #line default
            #line hidden
            
            #line 15 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NameSpace));
            
            #line default
            #line hidden
            
            #line 15 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\n{\n\t[BenchFixture]\n\tpublic partial class ArraysBench\n\t{\n\t\tconst int nIter = 10000;\n\n\t\tpublic ArraysBench ()\n\t\t{\n\t\t\t");
            
            #line default
            #line hidden
            
            #line 24 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 InitializeSerializer(); 
            
            #line default
            #line hidden
            
            #line 25 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t}\n");
            
            #line default
            #line hidden
            
            #line 26 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"

	foreach (BenchTypeInfo typeInfo in SerializedTypes) {

            
            #line default
            #line hidden
            
            #line 29 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\n\t\t[Bench]\n\t\t[Iterations(");
            
            #line default
            #line hidden
            
            #line 31 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Iterations));
            
            #line default
            #line hidden
            
            #line 31 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(")]\n\t\tpublic void Serialize");
            
            #line default
            #line hidden
            
            #line 32 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 32 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("Stream()\n\t\t{\n\t\t\t//BinarySerializer ser = new BinarySerializer ();\n\t\t\t");
            
            #line default
            #line hidden
            
            #line 35 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 InstantiateSerializer("ser",typeInfo.Name); 
            
            #line default
            #line hidden
            
            #line 36 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\tvar arr = ");
            
            #line default
            #line hidden
            
            #line 36 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 36 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(".Create();\n\n\t\t\tvar b = Benchmark.StartNew ();\n\n\t\t\tfor (int i = 0; i < ");
            
            #line default
            #line hidden
            
            #line 40 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Iterations));
            
            #line default
            #line hidden
            
            #line 40 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("; i++) {\n\t\t\t\tbyte[] res;\n\t\t\t\tusing (MemoryStream ms = new MemoryStream ()) {\n\t\t\t\t\t//ser.Serialize (ms, arr);\n\t\t\t\t\t");
            
            #line default
            #line hidden
            
            #line 44 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 Serialize("ser","arr",typeInfo.Name,"ms"); 
            
            #line default
            #line hidden
            
            #line 45 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\t\t\tres = ms.ToArray ();\n\t\t\t\t}\n\t\t\t}\n\n\t\t\tb.Stop ();\n\t\t}\n\t\n\t\t[Bench]\n\t\t[Iterations(");
            
            #line default
            #line hidden
            
            #line 53 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Iterations));
            
            #line default
            #line hidden
            
            #line 53 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(")]\n\t\tpublic void Deserialize");
            
            #line default
            #line hidden
            
            #line 54 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 54 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("Stream()\n\t\t{\n\n\t\t\t");
            
            #line default
            #line hidden
            
            #line 57 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 InstantiateSerializer("ser",typeInfo.Name); 
            
            #line default
            #line hidden
            
            #line 58 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\tvar arr = ");
            
            #line default
            #line hidden
            
            #line 58 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 58 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(".Create();\n\t\t\tbyte[] data;\n\n\t\t\tusing (MemoryStream ms = new MemoryStream ()) {\n\t\t\t\t");
            
            #line default
            #line hidden
            
            #line 62 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 Serialize("ser","arr",typeInfo.Name,"ms"); 
            
            #line default
            #line hidden
            
            #line 63 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\t\tdata = ms.ToArray ();\n\t\t\t}\n\n\t\t\tvar b = Benchmark.StartNew ();\n\n\t\t\tfor (int i = 0; i < ");
            
            #line default
            #line hidden
            
            #line 68 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Iterations));
            
            #line default
            #line hidden
            
            #line 68 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("; i++) {\n\t\t\t\tusing (MemoryStream ms = new MemoryStream (data)) {\n\t\t\t\t\t");
            
            #line default
            #line hidden
            
            #line 70 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 70 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(" des=");
            
            #line default
            #line hidden
            
            #line 70 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 Deserialize("ser","arr",typeInfo.Name,"ms"); 
            
            #line default
            #line hidden
            
            #line 71 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\t\t}\n\t\t\t}\n\n\t\t\tb.Stop ();\n\n\t\t\t//Verification\n\t\t\t");
            
            #line default
            #line hidden
            
            #line 77 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 77 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(" des1;\n\n\t\t\tusing (MemoryStream ms = new MemoryStream (data)) {\n\t\t\t\tdes1=");
            
            #line default
            #line hidden
            
            #line 80 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 Deserialize("ser","arr",typeInfo.Name,"ms"); 
            
            #line default
            #line hidden
            
            #line 81 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\t\t\t}\n\n\t\t\t");
            
            #line default
            #line hidden
            
            #line 83 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Name));
            
            #line default
            #line hidden
            
            #line 83 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write(".Compare (arr, des1);\n\n\t\t}\n");
            
            #line default
            #line hidden
            
            #line 86 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
 	}

            
            #line default
            #line hidden
            
            #line 88 "/home/sergey/Projects/SerializersBenchmarks/SerializersBenchmarks/Templates/BenchArrayBase.tt"
            this.Write("\n\t}\n}\n\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class BenchArrayBaseBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((this.formatProvider == null)) {
                        throw new global::System.ArgumentNullException("formatProvider");
                    }
                    this.formatProvider = value;
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
