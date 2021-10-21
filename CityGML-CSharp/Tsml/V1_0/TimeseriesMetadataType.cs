
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
[System.Xml.Serialization.XmlRootAttribute("TimeseriesMetadata", Namespace="http://www.opengis.net/tsml/1.0", IsNullable=false)]
public partial class TimeseriesMetadataType {
    
    private TimePeriodPropertyType temporalExtentField;
    
    private TimePositionType baseTimeField;
    
    private string spacingField;
    
    private CommentBlockPropertyType[] commentBlockField;
    
    private TimePeriodPropertyType intendedObservationSpacingField;
    
    private ReferenceType statusField;
    
    private bool cumulativeField;
    
    private bool cumulativeFieldSpecified;
    
    private TimeInstantPropertyType accumulationAnchorTimeField;
    
    private ReferenceType sampledMediumField;
    
    private string accumulationIntervalLengthField;
    
    private TimePositionType startAnchorPointField;
    
    private TimePositionType endAnchorPointField;
    
    private string maxGapPeriodField;
    
    private NamedValuePropertyType[] parameterField;
    
    /// <remarks/>
    public TimePeriodPropertyType temporalExtent {
        get {
            return this.temporalExtentField;
        }
        set {
            this.temporalExtentField = value;
        }
    }
    
    /// <remarks/>
    public TimePositionType baseTime {
        get {
            return this.baseTimeField;
        }
        set {
            this.baseTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string spacing {
        get {
            return this.spacingField;
        }
        set {
            this.spacingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("commentBlock")]
    public CommentBlockPropertyType[] commentBlock {
        get {
            return this.commentBlockField;
        }
        set {
            this.commentBlockField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodPropertyType intendedObservationSpacing {
        get {
            return this.intendedObservationSpacingField;
        }
        set {
            this.intendedObservationSpacingField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public bool cumulative {
        get {
            return this.cumulativeField;
        }
        set {
            this.cumulativeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cumulativeSpecified {
        get {
            return this.cumulativeFieldSpecified;
        }
        set {
            this.cumulativeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimeInstantPropertyType accumulationAnchorTime {
        get {
            return this.accumulationAnchorTimeField;
        }
        set {
            this.accumulationAnchorTimeField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType sampledMedium {
        get {
            return this.sampledMediumField;
        }
        set {
            this.sampledMediumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string accumulationIntervalLength {
        get {
            return this.accumulationIntervalLengthField;
        }
        set {
            this.accumulationIntervalLengthField = value;
        }
    }
    
    /// <remarks/>
    public TimePositionType startAnchorPoint {
        get {
            return this.startAnchorPointField;
        }
        set {
            this.startAnchorPointField = value;
        }
    }
    
    /// <remarks/>
    public TimePositionType endAnchorPoint {
        get {
            return this.endAnchorPointField;
        }
        set {
            this.endAnchorPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string maxGapPeriod {
        get {
            return this.maxGapPeriodField;
        }
        set {
            this.maxGapPeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public NamedValuePropertyType[] parameter {
        get {
            return this.parameterField;
        }
        set {
            this.parameterField = value;
        }
    }
}
}