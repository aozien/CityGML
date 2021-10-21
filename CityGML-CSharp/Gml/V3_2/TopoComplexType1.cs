
/**
* @author aozien
*/

// Granted under LGPL-2.0 License
// Copyright (c) 2021 Abdulrahman Zien https://github.com/aozien, files were generated based on the schema specs
 
using System;
using System.Xml.Serialization;

using CityGMLSharp.Citygml.Appearance.V3_0;
using CityGMLSharp.Gml.V3_2;
using CityGMLSharp.SamplingSpatial.V2_0;
using CityGMLSharp.Om.V2_0;
using CityGMLSharp.Gmd;
using CityGMLSharp.Gco;
using CityGMLSharp.Gss;
using CityGMLSharp.Gml;
using CityGMLSharp.Gts;
using CityGMLSharp.Gsr;
using CityGMLSharp.Citygml.Cityobjectgroup.V3_0;
using CityGMLSharp.Citygml.V3_0;
using CityGMLSharp.Tsml.V1_0;
using CityGMLSharp.Citygml.Generics.V3_0;
using CityGMLSharp.Citygml.Dynamizer.V3_0;
using CityGMLSharp.Swe.V2_0;
using CityGMLSharp.Gmlcov.V1_0;
using CityGMLSharp.Sos.V2_0;
using CityGMLSharp.Swes.V2_0;
using CityGMLSharp.Citygml.Versioning.V3_0;
using CityGMLSharp.Citygml.Waterbody.V3_0;
using CityGMLSharp.Citygml.Landuse.V3_0;
using CityGMLSharp.Citygml.Construction.V3_0;
using CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0;
using CityGMLSharp.Citygml.Transportation.V3_0;
using CityGMLSharp.Citygml.Relief.V3_0;
using CityGMLSharp.Citygml.Building.V3_0;
using CityGMLSharp.Citygml.Tunnel.V3_0;
using CityGMLSharp.Citygml.Bridge.V3_0;
using CityGMLSharp.Citygml.Vegetation.V3_0;
using CityGMLSharp.Citygml.Cityfurniture.V3_0;
using CityGMLSharp.Sampling.V2_0;
using CityGMLSharp.Addressing;
using CityGMLSharp.Fes.V2_0;
using CityGMLSharp.Ows.V1_1;
using CityGMLSharp.Wsn.T_1;
namespace CityGMLSharp.Gml.V3_2
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="TopoComplexType", Namespace="http://www.opengis.net/gml/3.2")]
[System.Xml.Serialization.XmlRootAttribute("TopoComplex", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
public partial class TopoComplexType1 : AbstractTopologyType1 {
    
    private TopoComplexPropertyType maximalComplexField;
    
    private TopoComplexPropertyType[] superComplexField;
    
    private TopoComplexPropertyType[] subComplexField;
    
    private TopoPrimitiveMemberType1[] topoPrimitiveMemberField;
    
    private TopoPrimitiveArrayAssociationType1 topoPrimitiveMembersField;
    
    private bool isMaximalField;
    
    private AggregationType aggregationTypeField;
    
    private bool aggregationTypeFieldSpecified;
    
    public TopoComplexType1() {
        this.isMaximalField = false;
    }
    
    /// <remarks/>
    public TopoComplexPropertyType maximalComplex {
        get {
            return this.maximalComplexField;
        }
        set {
            this.maximalComplexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("superComplex")]
    public TopoComplexPropertyType[] superComplex {
        get {
            return this.superComplexField;
        }
        set {
            this.superComplexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("subComplex")]
    public TopoComplexPropertyType[] subComplex {
        get {
            return this.subComplexField;
        }
        set {
            this.subComplexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("topoPrimitiveMember")]
    public TopoPrimitiveMemberType1[] topoPrimitiveMember {
        get {
            return this.topoPrimitiveMemberField;
        }
        set {
            this.topoPrimitiveMemberField = value;
        }
    }
    
    /// <remarks/>
    public TopoPrimitiveArrayAssociationType1 topoPrimitiveMembers {
        get {
            return this.topoPrimitiveMembersField;
        }
        set {
            this.topoPrimitiveMembersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isMaximal {
        get {
            return this.isMaximalField;
        }
        set {
            this.isMaximalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType {
        get {
            return this.aggregationTypeField;
        }
        set {
            this.aggregationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified {
        get {
            return this.aggregationTypeFieldSpecified;
        }
        set {
            this.aggregationTypeFieldSpecified = value;
        }
    }
}
}