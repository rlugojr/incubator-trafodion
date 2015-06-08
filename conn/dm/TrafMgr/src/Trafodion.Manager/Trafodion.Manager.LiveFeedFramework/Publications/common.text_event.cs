// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: common.text_event.proto
// Note: requires additional types generated from: common.event_header.proto
// Note: requires additional types generated from: common.qpid_header.proto
namespace common
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"text_event")]
  public partial class text_event : global::ProtoBuf.IExtensible
  {
    public text_event() {}
    
    private common.event_header _header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public common.event_header header
    {
      get { return _header; }
      set { _header = value; }
    }
    private string _text;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }

    private string _tokenized_event_repos_table = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"tokenized_event_repos_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tokenized_event_repos_table
    {
      get { return _tokenized_event_repos_table; }
      set { _tokenized_event_repos_table = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
