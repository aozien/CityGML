
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AffineCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
public abstract partial class AbstractCoordinateSystemType : IdentifiedObjectType1 {
    
    private CoordinateSystemAxisPropertyType[] axisField;
    
    private AggregationType1 aggregationTypeField;
    
    private bool aggregationTypeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("axis")]
    public CoordinateSystemAxisPropertyType[] axis {
        get {
            return this.axisField;
        }
        set {
            this.axisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType1 aggregationType {
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