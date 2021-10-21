
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
[System.Xml.Serialization.XmlRootAttribute("MD_ImageDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_ImageDescription_Type : MD_CoverageDescription_Type {
    
    private Real_PropertyType illuminationElevationAngleField;
    
    private Real_PropertyType illuminationAzimuthAngleField;
    
    private MD_ImagingConditionCode_PropertyType imagingConditionField;
    
    private MD_Identifier_PropertyType imageQualityCodeField;
    
    private Real_PropertyType cloudCoverPercentageField;
    
    private MD_Identifier_PropertyType processingLevelCodeField;
    
    private Integer_PropertyType compressionGenerationQuantityField;
    
    private Boolean_PropertyType triangulationIndicatorField;
    
    private Boolean_PropertyType radiometricCalibrationDataAvailabilityField;
    
    private Boolean_PropertyType cameraCalibrationInformationAvailabilityField;
    
    private Boolean_PropertyType filmDistortionInformationAvailabilityField;
    
    private Boolean_PropertyType lensDistortionInformationAvailabilityField;
    
    /// <remarks/>
    public Real_PropertyType illuminationElevationAngle {
        get {
            return this.illuminationElevationAngleField;
        }
        set {
            this.illuminationElevationAngleField = value;
        }
    }
    
    /// <remarks/>
    public Real_PropertyType illuminationAzimuthAngle {
        get {
            return this.illuminationAzimuthAngleField;
        }
        set {
            this.illuminationAzimuthAngleField = value;
        }
    }
    
    /// <remarks/>
    public MD_ImagingConditionCode_PropertyType imagingCondition {
        get {
            return this.imagingConditionField;
        }
        set {
            this.imagingConditionField = value;
        }
    }
    
    /// <remarks/>
    public MD_Identifier_PropertyType imageQualityCode {
        get {
            return this.imageQualityCodeField;
        }
        set {
            this.imageQualityCodeField = value;
        }
    }
    
    /// <remarks/>
    public Real_PropertyType cloudCoverPercentage {
        get {
            return this.cloudCoverPercentageField;
        }
        set {
            this.cloudCoverPercentageField = value;
        }
    }
    
    /// <remarks/>
    public MD_Identifier_PropertyType processingLevelCode {
        get {
            return this.processingLevelCodeField;
        }
        set {
            this.processingLevelCodeField = value;
        }
    }
    
    /// <remarks/>
    public Integer_PropertyType compressionGenerationQuantity {
        get {
            return this.compressionGenerationQuantityField;
        }
        set {
            this.compressionGenerationQuantityField = value;
        }
    }
    
    /// <remarks/>
    public Boolean_PropertyType triangulationIndicator {
        get {
            return this.triangulationIndicatorField;
        }
        set {
            this.triangulationIndicatorField = value;
        }
    }
    
    /// <remarks/>
    public Boolean_PropertyType radiometricCalibrationDataAvailability {
        get {
            return this.radiometricCalibrationDataAvailabilityField;
        }
        set {
            this.radiometricCalibrationDataAvailabilityField = value;
        }
    }
    
    /// <remarks/>
    public Boolean_PropertyType cameraCalibrationInformationAvailability {
        get {
            return this.cameraCalibrationInformationAvailabilityField;
        }
        set {
            this.cameraCalibrationInformationAvailabilityField = value;
        }
    }
    
    /// <remarks/>
    public Boolean_PropertyType filmDistortionInformationAvailability {
        get {
            return this.filmDistortionInformationAvailabilityField;
        }
        set {
            this.filmDistortionInformationAvailabilityField = value;
        }
    }
    
    /// <remarks/>
    public Boolean_PropertyType lensDistortionInformationAvailability {
        get {
            return this.lensDistortionInformationAvailabilityField;
        }
        set {
            this.lensDistortionInformationAvailabilityField = value;
        }
    }
}
}