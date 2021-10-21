
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="CoordinateSystemAxisType", Namespace="http://www.opengis.net/gml/3.2")]
[System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
public partial class CoordinateSystemAxisType1 : IdentifiedObjectType {
    
    private CodeType axisAbbrevField;
    
    private CodeWithAuthorityType axisDirectionField;
    
    private double minimumValueField;
    
    private bool minimumValueFieldSpecified;
    
    private double maximumValueField;
    
    private bool maximumValueFieldSpecified;
    
    private CodeWithAuthorityType rangeMeaningField;
    
    private string uomField;
    
    /// <remarks/>
    public CodeType axisAbbrev {
        get {
            return this.axisAbbrevField;
        }
        set {
            this.axisAbbrevField = value;
        }
    }
    
    /// <remarks/>
    public CodeWithAuthorityType axisDirection {
        get {
            return this.axisDirectionField;
        }
        set {
            this.axisDirectionField = value;
        }
    }
    
    /// <remarks/>
    public double minimumValue {
        get {
            return this.minimumValueField;
        }
        set {
            this.minimumValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumValueSpecified {
        get {
            return this.minimumValueFieldSpecified;
        }
        set {
            this.minimumValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public double maximumValue {
        get {
            return this.maximumValueField;
        }
        set {
            this.maximumValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumValueSpecified {
        get {
            return this.maximumValueFieldSpecified;
        }
        set {
            this.maximumValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CodeWithAuthorityType rangeMeaning {
        get {
            return this.rangeMeaningField;
        }
        set {
            this.rangeMeaningField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom {
        get {
            return this.uomField;
        }
        set {
            this.uomField = value;
        }
    }
}
}