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
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("33b1599e-416e-4c94-9726-005a8cc6c9ef")]
	public partial class IfcPlanarExtent : IfcGeometricRepresentationItem
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _SizeInX;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _SizeInY;
	
	
		[Description("<EPM-HTML>\r\nThe extent in the direction of the x-axis.\r\n</EPM-HTML>")]
		public IfcLengthMeasure SizeInX { get { return this._SizeInX; } set { this._SizeInX = value;} }
	
		[Description("<EPM-HTML>\r\nThe extent in the direction of the y-axis.\r\n</EPM-HTML>")]
		public IfcLengthMeasure SizeInY { get { return this._SizeInY; } set { this._SizeInY = value;} }
	
	
	}
	
}