
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
namespace CityGMLSharp.Fes.V2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/fes/2.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
public partial class Filter_Capabilities {
    
    private DomainType[] conformanceField;
    
    private ResourceIdentifierType[] id_CapabilitiesField;
    
    private Scalar_CapabilitiesType scalar_CapabilitiesField;
    
    private Spatial_CapabilitiesType spatial_CapabilitiesField;
    
    private Temporal_CapabilitiesType temporal_CapabilitiesField;
    
    private AvailableFunctionType[] functionsField;
    
    private Extended_CapabilitiesType extended_CapabilitiesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Constraint", IsNullable=false)]
    public DomainType[] Conformance {
        get {
            return this.conformanceField;
        }
        set {
            this.conformanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ResourceIdentifier", IsNullable=false)]
    public ResourceIdentifierType[] Id_Capabilities {
        get {
            return this.id_CapabilitiesField;
        }
        set {
            this.id_CapabilitiesField = value;
        }
    }
    
    /// <remarks/>
    public Scalar_CapabilitiesType Scalar_Capabilities {
        get {
            return this.scalar_CapabilitiesField;
        }
        set {
            this.scalar_CapabilitiesField = value;
        }
    }
    
    /// <remarks/>
    public Spatial_CapabilitiesType Spatial_Capabilities {
        get {
            return this.spatial_CapabilitiesField;
        }
        set {
            this.spatial_CapabilitiesField = value;
        }
    }
    
    /// <remarks/>
    public Temporal_CapabilitiesType Temporal_Capabilities {
        get {
            return this.temporal_CapabilitiesField;
        }
        set {
            this.temporal_CapabilitiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Function", IsNullable=false)]
    public AvailableFunctionType[] Functions {
        get {
            return this.functionsField;
        }
        set {
            this.functionsField = value;
        }
    }
    
    /// <remarks/>
    public Extended_CapabilitiesType Extended_Capabilities {
        get {
            return this.extended_CapabilitiesField;
        }
        set {
            this.extended_CapabilitiesField = value;
        }
    }
}
}