
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
namespace CityGMLSharp.Citygml.Transportation.V3_0
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RoadType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RailwayType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/transportation/3.0")]
[System.Xml.Serialization.XmlRootAttribute("TransportationComplex", Namespace="http://www.opengis.net/citygml/transportation/3.0", IsNullable=false)]
public partial class TransportationComplexType : AbstractTopLevelCityObjectType {
    
    private CodeType classField;
    
    private CodeType[] functionField;
    
    private CodeType[] usageField;
    
    private TransportationComplexTypeAuxiliaryTrafficSpace[] auxiliaryTrafficSpaceField;
    
    private TransportationComplexTypeTransportationSpace[] transportationSpaceField;
    
    private TransportationComplexTypeTrafficSpace[] trafficSpaceField;
    
    private TransportationComplexTypeHole[] holeField;
    
    private GeometricComplexPropertyType lod0NetworkField;
    
    private GeometricComplexPropertyType lod1NetworkField;
    
    /// <remarks/>
    public CodeType @class {
        get {
            return this.classField;
        }
        set {
            this.classField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("function")]
    public CodeType[] function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("usage")]
    public CodeType[] usage {
        get {
            return this.usageField;
        }
        set {
            this.usageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("auxiliaryTrafficSpace")]
    public TransportationComplexTypeAuxiliaryTrafficSpace[] auxiliaryTrafficSpace {
        get {
            return this.auxiliaryTrafficSpaceField;
        }
        set {
            this.auxiliaryTrafficSpaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("transportationSpace")]
    public TransportationComplexTypeTransportationSpace[] transportationSpace {
        get {
            return this.transportationSpaceField;
        }
        set {
            this.transportationSpaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("trafficSpace")]
    public TransportationComplexTypeTrafficSpace[] trafficSpace {
        get {
            return this.trafficSpaceField;
        }
        set {
            this.trafficSpaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hole")]
    public TransportationComplexTypeHole[] hole {
        get {
            return this.holeField;
        }
        set {
            this.holeField = value;
        }
    }
    
    /// <remarks/>
    public GeometricComplexPropertyType lod0Network {
        get {
            return this.lod0NetworkField;
        }
        set {
            this.lod0NetworkField = value;
        }
    }
    
    /// <remarks/>
    public GeometricComplexPropertyType lod1Network {
        get {
            return this.lod1NetworkField;
        }
        set {
            this.lod1NetworkField = value;
        }
    }
}
}