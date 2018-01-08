// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcRepresentationResource;

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("b99a5da2-c2da-4aef-add4-cbb2ab49a83d")]
	public partial class IfcMaterialConstituentSet : IfcMaterialDefinition
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLabel? _Name;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcText? _Description;
	
		[DataMember(Order=2)] 
		ISet<IfcMaterialConstituent> _MaterialConstituents = new HashSet<IfcMaterialConstituent>();
	
	
		[Description("<EPM-HTML>\r\nThe name by which the constituent set is known.\r\n</EPM-HTML>")]
		public IfcLabel? Name { get { return this._Name; } set { this._Name = value;} }
	
		[Description("<EPM-HTML>\r\nDefinition of the material constituent set in descriptive terms.\r\n</E" +
	    "PM-HTML>")]
		public IfcText? Description { get { return this._Description; } set { this._Description = value;} }
	
		[Description("<EPM-HTML>\r\nIdentification of the constituents from which the material constituen" +
	    "t set is composed.\r\n</EPM-HTML>")]
		public ISet<IfcMaterialConstituent> MaterialConstituents { get { return this._MaterialConstituents; } }
	
	
	}
	
}