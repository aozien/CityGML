
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
namespace CityGMLSharp.Swes.V2_0
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferingChangedType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorChangedType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorDescriptionUpdatedType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
[System.Xml.Serialization.XmlRootAttribute("SWESEvent", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
public partial class SWESEventType : AbstractSWESType {
    
    private System.DateTime eventTimeField;
    
    private string codeField;
    
    private LanguageStringType[] messageField;
    
    private SWESEventTypeService serviceField;
    
    /// <remarks/>
    public System.DateTime eventTime {
        get {
            return this.eventTimeField;
        }
        set {
            this.eventTimeField = value;
        }
    }
    
    /// <remarks/>
    public string code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("message")]
    public LanguageStringType[] message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
    
    /// <remarks/>
    public SWESEventTypeService service {
        get {
            return this.serviceField;
        }
        set {
            this.serviceField = value;
        }
    }
}
}