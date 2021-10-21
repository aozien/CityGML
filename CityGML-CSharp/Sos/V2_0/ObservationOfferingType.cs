
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
namespace CityGMLSharp.Sos.V2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
[System.Xml.Serialization.XmlRootAttribute("ObservationOffering", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
public partial class ObservationOfferingType : AbstractOfferingType {
    
    private ObservationOfferingTypeObservedArea observedAreaField;
    
    private ObservationOfferingTypePhenomenonTime phenomenonTimeField;
    
    private ObservationOfferingTypeResultTime resultTimeField;
    
    private string[] responseFormatField;
    
    private string[] observationTypeField;
    
    private string[] featureOfInterestTypeField;
    
    /// <remarks/>
    public ObservationOfferingTypeObservedArea observedArea {
        get {
            return this.observedAreaField;
        }
        set {
            this.observedAreaField = value;
        }
    }
    
    /// <remarks/>
    public ObservationOfferingTypePhenomenonTime phenomenonTime {
        get {
            return this.phenomenonTimeField;
        }
        set {
            this.phenomenonTimeField = value;
        }
    }
    
    /// <remarks/>
    public ObservationOfferingTypeResultTime resultTime {
        get {
            return this.resultTimeField;
        }
        set {
            this.resultTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("responseFormat", DataType="anyURI")]
    public string[] responseFormat {
        get {
            return this.responseFormatField;
        }
        set {
            this.responseFormatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
    public string[] observationType {
        get {
            return this.observationTypeField;
        }
        set {
            this.observationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
    public string[] featureOfInterestType {
        get {
            return this.featureOfInterestTypeField;
        }
        set {
            this.featureOfInterestTypeField = value;
        }
    }
}
}