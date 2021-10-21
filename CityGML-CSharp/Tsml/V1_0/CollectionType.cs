
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
[System.Xml.Serialization.XmlRootAttribute("Collection", Namespace="http://www.opengis.net/tsml/1.0", IsNullable=false)]
public partial class CollectionType : AbstractFeatureType {
    
    private object[] communityExtensionField;
    
    private object[] internalExtensionField;
    
    private System.DateTime generationDateField;
    
    private string generationSystemField;
    
    private ReferenceType versionField;
    
    private ReferenceType[] profileField;
    
    private TimePeriodPropertyType temporalExtentField;
    
    private CollectionTypeLocalDictionary[] localDictionaryField;
    
    private ReferenceType[] sourceDefinitionField;
    
    private NamedValuePropertyType[] parameterField;
    
    private SamplingFeatureMemberPropertyType[] samplingFeatureMemberField;
    
    private OM_ObservationPropertyType[] observationMemberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("communityExtension")]
    public object[] communityExtension {
        get {
            return this.communityExtensionField;
        }
        set {
            this.communityExtensionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("internalExtension")]
    public object[] internalExtension {
        get {
            return this.internalExtensionField;
        }
        set {
            this.internalExtensionField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime generationDate {
        get {
            return this.generationDateField;
        }
        set {
            this.generationDateField = value;
        }
    }
    
    /// <remarks/>
    public string generationSystem {
        get {
            return this.generationSystemField;
        }
        set {
            this.generationSystemField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("profile")]
    public ReferenceType[] profile {
        get {
            return this.profileField;
        }
        set {
            this.profileField = value;
        }
    }
    
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
    [System.Xml.Serialization.XmlElementAttribute("localDictionary")]
    public CollectionTypeLocalDictionary[] localDictionary {
        get {
            return this.localDictionaryField;
        }
        set {
            this.localDictionaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sourceDefinition")]
    public ReferenceType[] sourceDefinition {
        get {
            return this.sourceDefinitionField;
        }
        set {
            this.sourceDefinitionField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("samplingFeatureMember")]
    public SamplingFeatureMemberPropertyType[] samplingFeatureMember {
        get {
            return this.samplingFeatureMemberField;
        }
        set {
            this.samplingFeatureMemberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("observationMember")]
    public OM_ObservationPropertyType[] observationMember {
        get {
            return this.observationMemberField;
        }
        set {
            this.observationMemberField = value;
        }
    }
}
}