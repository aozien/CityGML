
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
namespace CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0")]
public partial class ThoroughfareDependentThoroughfare {
    
    private AddressLine[] addressLineField;
    
    private ThoroughfarePreDirectionType thoroughfarePreDirectionField;
    
    private ThoroughfareLeadingTypeType thoroughfareLeadingTypeField;
    
    private ThoroughfareNameType[] thoroughfareNameField;
    
    private ThoroughfareTrailingTypeType thoroughfareTrailingTypeField;
    
    private ThoroughfarePostDirectionType thoroughfarePostDirectionField;
    
    private System.Xml.XmlElement[] anyField;
    
    private string typeField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
    public AddressLine[] AddressLine {
        get {
            return this.addressLineField;
        }
        set {
            this.addressLineField = value;
        }
    }
    
    /// <remarks/>
    public ThoroughfarePreDirectionType ThoroughfarePreDirection {
        get {
            return this.thoroughfarePreDirectionField;
        }
        set {
            this.thoroughfarePreDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ThoroughfareLeadingTypeType ThoroughfareLeadingType {
        get {
            return this.thoroughfareLeadingTypeField;
        }
        set {
            this.thoroughfareLeadingTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ThoroughfareName")]
    public ThoroughfareNameType[] ThoroughfareName {
        get {
            return this.thoroughfareNameField;
        }
        set {
            this.thoroughfareNameField = value;
        }
    }
    
    /// <remarks/>
    public ThoroughfareTrailingTypeType ThoroughfareTrailingType {
        get {
            return this.thoroughfareTrailingTypeField;
        }
        set {
            this.thoroughfareTrailingTypeField = value;
        }
    }
    
    /// <remarks/>
    public ThoroughfarePostDirectionType ThoroughfarePostDirection {
        get {
            return this.thoroughfarePostDirectionField;
        }
        set {
            this.thoroughfarePostDirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}
}