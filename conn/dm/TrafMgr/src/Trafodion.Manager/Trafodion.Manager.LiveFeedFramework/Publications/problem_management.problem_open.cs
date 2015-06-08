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

// Generated from: problem_management.problem_open.proto
// Note: requires additional types generated from: common.info_header.proto
namespace problem_management
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"problem_open")]
  public partial class problem_open : global::ProtoBuf.IExtensible
  {
    public problem_open() {}
    
    private common.info_header _header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public common.info_header header
    {
      get { return _header; }
      set { _header = value; }
    }
    private long _creation_time_ts_utc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"creation_time_ts_utc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long creation_time_ts_utc
    {
      get { return _creation_time_ts_utc; }
      set { _creation_time_ts_utc = value; }
    }
    private long _creation_time_ts_lct;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"creation_time_ts_lct", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long creation_time_ts_lct
    {
      get { return _creation_time_ts_lct; }
      set { _creation_time_ts_lct = value; }
    }
    private int _creator_process_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"creator_process_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int creator_process_id
    {
      get { return _creator_process_id; }
      set { _creator_process_id = value; }
    }
    private uint _creator_host_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"creator_host_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint creator_host_id
    {
      get { return _creator_host_id; }
      set { _creator_host_id = value; }
    }

    private uint _problem_instance_id = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"problem_instance_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_instance_id
    {
      get { return _problem_instance_id; }
      set { _problem_instance_id = value; }
    }

    private uint _problem_tenant_id = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"problem_tenant_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_tenant_id
    {
      get { return _problem_tenant_id; }
      set { _problem_tenant_id = value; }
    }

    private uint _problem_component_id = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"problem_component_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_component_id
    {
      get { return _problem_component_id; }
      set { _problem_component_id = value; }
    }

    private uint _problem_thread_id = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"problem_thread_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_thread_id
    {
      get { return _problem_thread_id; }
      set { _problem_thread_id = value; }
    }

    private int _problem_process_id = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"problem_process_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int problem_process_id
    {
      get { return _problem_process_id; }
      set { _problem_process_id = value; }
    }

    private string _problem_process_name = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"problem_process_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string problem_process_name
    {
      get { return _problem_process_name; }
      set { _problem_process_name = value; }
    }

    private uint _problem_node_id = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"problem_node_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_node_id
    {
      get { return _problem_node_id; }
      set { _problem_node_id = value; }
    }

    private uint _problem_pnid_id = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"problem_pnid_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_pnid_id
    {
      get { return _problem_pnid_id; }
      set { _problem_pnid_id = value; }
    }

    private uint _problem_host_id = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"problem_host_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint problem_host_id
    {
      get { return _problem_host_id; }
      set { _problem_host_id = value; }
    }

    private string _problem_ip_address_id = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"problem_ip_address_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string problem_ip_address_id
    {
      get { return _problem_ip_address_id; }
      set { _problem_ip_address_id = value; }
    }
    private string _resource_name;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"resource_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string resource_name
    {
      get { return _resource_name; }
      set { _resource_name = value; }
    }
    private string _resource_type;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"resource_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string resource_type
    {
      get { return _resource_type; }
      set { _resource_type = value; }
    }
    private int _severity;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int severity
    {
      get { return _severity; }
      set { _severity = value; }
    }
    private string _status;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string status
    {
      get { return _status; }
      set { _status = value; }
    }

    private string _description = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string description
    {
      get { return _description; }
      set { _description = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
