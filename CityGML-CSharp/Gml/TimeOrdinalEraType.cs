
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
[System.Xml.Serialization.XmlRootAttribute("TimeOrdinalEra", Namespace="http://www.opengis.net/gml", IsNullable=false)]
public partial class TimeOrdinalEraType : DefinitionType1 {
    
    private RelatedTimeType1[] relatedTimeField;
    
    private TimeNodePropertyType1 startField;
    
    private TimeNodePropertyType1 endField;
    
    private TimePeriodPropertyType1 extentField;
    
    private TimeOrdinalEraPropertyType[] memberField;
    
    private ReferenceType1 groupField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
    public RelatedTimeType1[] relatedTime {
        get {
            return this.relatedTimeField;
        }
        set {
            this.relatedTimeField = value;
        }
    }
    
    /// <remarks/>
    public TimeNodePropertyType1 start {
        get {
            return this.startField;
        }
        set {
            this.startField = value;
        }
    }
    
    /// <remarks/>
    public TimeNodePropertyType1 end {
        get {
            return this.endField;
        }
        set {
            this.endField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodPropertyType1 extent {
        get {
            return this.extentField;
        }
        set {
            this.extentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("member")]
    public TimeOrdinalEraPropertyType[] member {
        get {
            return this.memberField;
        }
        set {
            this.memberField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType1 group {
        get {
            return this.groupField;
        }
        set {
            this.groupField = value;
        }
    }
}
}