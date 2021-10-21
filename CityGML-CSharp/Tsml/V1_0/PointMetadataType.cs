
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
namespace CityGMLSharp.Tsml.V1_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/tsml/1.0")]
[System.Xml.Serialization.XmlRootAttribute("PointMetadata", Namespace="http://www.opengis.net/tsml/1.0", IsNullable=false)]
public partial class PointMetadataType {
    
    private ReferenceType qualityField;
    
    private UnitReference uomField;
    
    private ReferenceType interpolationTypeField;
    
    private ReferenceType nilReasonField;
    
    private ReferenceType censoredReasonField;
    
    private string commentField;
    
    private QuantityPropertyType uncertaintyField;
    
    private OM_ObservationPropertyType relatedObservationField;
    
    private string aggregationDurationField;
    
    private QuantityPropertyType[] qualifierField;
    
    private ReferenceType processingField;
    
    private ReferenceType sourceField;
    
    /// <remarks/>
    public ReferenceType quality {
        get {
            return this.qualityField;
        }
        set {
            this.qualityField = value;
        }
    }
    
    /// <remarks/>
    public UnitReference uom {
        get {
            return this.uomField;
        }
        set {
            this.uomField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType interpolationType {
        get {
            return this.interpolationTypeField;
        }
        set {
            this.interpolationTypeField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType nilReason {
        get {
            return this.nilReasonField;
        }
        set {
            this.nilReasonField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType censoredReason {
        get {
            return this.censoredReasonField;
        }
        set {
            this.censoredReasonField = value;
        }
    }
    
    /// <remarks/>
    public string comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
    
    /// <remarks/>
    public QuantityPropertyType uncertainty {
        get {
            return this.uncertaintyField;
        }
        set {
            this.uncertaintyField = value;
        }
    }
    
    /// <remarks/>
    public OM_ObservationPropertyType relatedObservation {
        get {
            return this.relatedObservationField;
        }
        set {
            this.relatedObservationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string aggregationDuration {
        get {
            return this.aggregationDurationField;
        }
        set {
            this.aggregationDurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("qualifier")]
    public QuantityPropertyType[] qualifier {
        get {
            return this.qualifierField;
        }
        set {
            this.qualifierField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType processing {
        get {
            return this.processingField;
        }
        set {
            this.processingField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
}
}