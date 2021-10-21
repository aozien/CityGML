
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
[System.Xml.Serialization.XmlRootAttribute("MD_Distributor", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_Distributor_Type : AbstractObject_Type {
    
    private CI_ResponsibleParty_PropertyType distributorContactField;
    
    private MD_StandardOrderProcess_PropertyType[] distributionOrderProcessField;
    
    private MD_Format_PropertyType[] distributorFormatField;
    
    private MD_DigitalTransferOptions_PropertyType[] distributorTransferOptionsField;
    
    /// <remarks/>
    public CI_ResponsibleParty_PropertyType distributorContact {
        get {
            return this.distributorContactField;
        }
        set {
            this.distributorContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("distributionOrderProcess")]
    public MD_StandardOrderProcess_PropertyType[] distributionOrderProcess {
        get {
            return this.distributionOrderProcessField;
        }
        set {
            this.distributionOrderProcessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("distributorFormat")]
    public MD_Format_PropertyType[] distributorFormat {
        get {
            return this.distributorFormatField;
        }
        set {
            this.distributorFormatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("distributorTransferOptions")]
    public MD_DigitalTransferOptions_PropertyType[] distributorTransferOptions {
        get {
            return this.distributorTransferOptionsField;
        }
        set {
            this.distributorTransferOptionsField = value;
        }
    }
}
}