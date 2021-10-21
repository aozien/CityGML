
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
namespace CityGMLSharp.Gml
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="SequenceRuleType", Namespace="http://www.opengis.net/gml")]
public partial class SequenceRuleType1 {
    
    private IncrementOrder1 orderField;
    
    private bool orderFieldSpecified;
    
    private string[] axisOrderField;
    
    private SequenceRuleEnumeration1 valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public IncrementOrder1 order {
        get {
            return this.orderField;
        }
        set {
            this.orderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool orderSpecified {
        get {
            return this.orderFieldSpecified;
        }
        set {
            this.orderFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string[] axisOrder {
        get {
            return this.axisOrderField;
        }
        set {
            this.axisOrderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public SequenceRuleEnumeration1 Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="IncrementOrder", Namespace="http://www.opengis.net/gml")]
public enum IncrementOrder1 {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+x+y")]
    xy,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+y+x")]
    yx,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+x-y")]
    xy1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("-x-y")]
    xy2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="SequenceRuleEnumeration", Namespace="http://www.opengis.net/gml")]
public enum SequenceRuleEnumeration1 {
    
    /// <remarks/>
    Linear,
    
    /// <remarks/>
    Boustrophedonic,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Cantor-diagonal")]
    Cantordiagonal,
    
    /// <remarks/>
    Spiral,
    
    /// <remarks/>
    Morton,
    
    /// <remarks/>
    Hilbert,
}
}