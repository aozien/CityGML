
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
namespace CityGMLSharp.Gmd
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
[System.Xml.Serialization.XmlRootAttribute("MD_MaintenanceInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_MaintenanceInformation_Type : AbstractObject_Type {
    
    private MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequencyField;
    
    private Date_PropertyType dateOfNextUpdateField;
    
    private TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequencyField;
    
    private MD_ScopeCode_PropertyType[] updateScopeField;
    
    private MD_ScopeDescription_PropertyType[] updateScopeDescriptionField;
    
    private CharacterString_PropertyType[] maintenanceNoteField;
    
    private CI_ResponsibleParty_PropertyType[] contactField;
    
    /// <remarks/>
    public MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequency {
        get {
            return this.maintenanceAndUpdateFrequencyField;
        }
        set {
            this.maintenanceAndUpdateFrequencyField = value;
        }
    }
    
    /// <remarks/>
    public Date_PropertyType dateOfNextUpdate {
        get {
            return this.dateOfNextUpdateField;
        }
        set {
            this.dateOfNextUpdateField = value;
        }
    }
    
    /// <remarks/>
    public TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequency {
        get {
            return this.userDefinedMaintenanceFrequencyField;
        }
        set {
            this.userDefinedMaintenanceFrequencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("updateScope")]
    public MD_ScopeCode_PropertyType[] updateScope {
        get {
            return this.updateScopeField;
        }
        set {
            this.updateScopeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("updateScopeDescription")]
    public MD_ScopeDescription_PropertyType[] updateScopeDescription {
        get {
            return this.updateScopeDescriptionField;
        }
        set {
            this.updateScopeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("maintenanceNote")]
    public CharacterString_PropertyType[] maintenanceNote {
        get {
            return this.maintenanceNoteField;
        }
        set {
            this.maintenanceNoteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("contact")]
    public CI_ResponsibleParty_PropertyType[] contact {
        get {
            return this.contactField;
        }
        set {
            this.contactField = value;
        }
    }
}
}