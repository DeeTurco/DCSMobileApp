using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DSHS.DCS.Data
{
   public static class OfficeLocation
   {
	  private const string mOfficeCityPhone = "1-800-442-KIDS";
	  private const string mOfficeCityPhoneTDD = "800-833-6384";
	  private const string mOfficeHours = "Office Hours: 8:00 am - 5:00 pm, Monday - Friday";
	  private const string mPhysicalAddressOffice = "What is the Physical Address of the office?";
	  private const string mFax = "1-866-668-9518";
	  private const string mSendDocument = "Where should you send documents?";
	  private const string mDCS = "Division of Child Support";
	  private const string mDocAddress = "PO BOX 11520";
	  private const string mDocAddressCityStateZip = "Tacoma, WA 98411-5520";
	  public static IList<OfficeMetadata> OLocation { get; private set; }

	  static OfficeLocation()
	  {
		 OLocation = new ObservableCollection<OfficeMetadata> {
			new OfficeMetadata {
			   OfficeCity = "Everett Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   OfficeCityPhoneTDD = mOfficeCityPhoneTDD,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "840 N Broadway Ste 400 Building B",
			   PhysicalAddressCityStateZip = "Everett, WA",
			   Email = "everett-dcs@dshs.wa.gov",
			   Phone = "(425) 438-4800",
			   Phone1800 = "(800) 729-7580",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Patti Dalrymple",
			},

			new OfficeMetadata {
			   OfficeCity = "Kennewick Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "1120 N. Edison St.",
			   PhysicalAddressCityStateZip = "Kennewick, WA 99336",
			   Email = "ken-imail@dshs.wa.gov",
			   Phone = "(509) 374-2000",
			   Phone1800 = "(800) 345-9981",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Camille Little",
			},

			new OfficeMetadata {
			   OfficeCity = "Olympia Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "TC3, 5th Floor, 243 Israel Road",
			   PhysicalAddressCityStateZip = "Tumwater, WA 98501",
			   Email = "oly-imail@dshs.wa.gov",
			   Phone = "(360) 664-6900",
			   Phone1800 = "(800) 345-9964",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Glenda Nelson",
			},

			new OfficeMetadata {
			   OfficeCity = "Seattle Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "500 First Avenue South",
			   PhysicalAddressCityStateZip = "Seattle, WA 98104",
			   Email = "seattle-dcs@dshs.wa.gov",
			   Phone = "(206) 341-7000",
			   Phone1800 = "(800) 526-8658",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Sylvia Flores",
			},

			new OfficeMetadata {
			   OfficeCity = "Spokane Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "W. 1608 Boone",
			   PhysicalAddressCityStateZip = "Spokane, WA 99201",
			   Email = "spomail@dshs.wa.gov",
			   Phone = "(509) 363-5000",
			   Phone1800 = "(800) 345-9982",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Mark Swenson",
			},

			new OfficeMetadata {
			   OfficeCity = "Tacoma Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "1949 S State Street, 3rd floor",
			   PhysicalAddressCityStateZip = "Tacoma, WA 98405",
			   Email = "tacoma-dcs@dshs.wa.gov",
			   Phone = "(253) 597-3700",
			   Phone1800 = "(800) 345-9976",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Rena Hect",
			},

			new OfficeMetadata {
			   OfficeCity = "Vancouver Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "800 NE 136th Avenue",
			   PhysicalAddressCityStateZip = "Vancouver, WA 98684",
			   Email = "vancouver-dcs@dshs.wa.gov",
			   Phone = "(360) 696-6100",
			   Phone1800 = "(800) 345-9984",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Roger Johnson",
			},

			new OfficeMetadata {
			   OfficeCity = "Wenatchee Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "805 S. Mission",
			   PhysicalAddressCityStateZip = "Wenatchee, WA 98801",
			   Email = "wenatchee-dcs@dshs.wa.gov",
			   Phone = "(509) 886-6800",
			   Phone1800 = "(800) 535-1113",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Mark Swenson",
			},

			new OfficeMetadata {
			   OfficeCity = "Yakima Child Support Office",
			   OfficeCityPhone = mOfficeCityPhone,
			   PhysicalAddressOffice = mPhysicalAddressOffice,
			   OfficeHours = mOfficeHours,
			   PhysicalAddress = "1002 North 16th Avenue",
			   PhysicalAddressCityStateZip = "Yakima, WA 98902",
			   Email = "yak-imail@dshs.wa.gov",
			   Phone = "(509) 249-6000",
			   Phone1800 = "(800) 441-0859",
			   Fax = mFax,
			   SendDocument = mSendDocument,
			   DCS = mDCS,
			   DocAddress = mDocAddress,
			   DocAddressCityStateZip = mDocAddressCityStateZip,
			   DocDistrictManager = "Camille Little",
			},
		 };
	  }
   }
}
