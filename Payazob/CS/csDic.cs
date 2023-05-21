using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace MIS.CS
{
    public class csDic
    {
        string InsertSpace(string s)
        {

            if (s == null)
                return s;

            StringBuilder result = new StringBuilder();
            result.Append(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    result.Append(" ");
                result.Append(s[i]);
            }
            return result.ToString();
        }

        public string EnToFarsiCatalog(string StInput)
        {
            Dictionary<string, string> dictionary =
   new Dictionary<string, string>();

            dictionary.Add("xPhone", "تلفن ثابت");
            dictionary.Add("xMobile", "تلفن همراه");
            dictionary.Add("xCompanyPhone", "تلفن شرکت");
            dictionary.Add("xCompanyName", "نام شرکت");
            dictionary.Add("xGenGrpCustomer_", "گروه مشتری");

            dictionary.Add("xGenBuldingStatus_", "وضعیت ساختمان ");
            dictionary.Add("xGenUsageType_", "نوع کاربری");
            dictionary.Add("xBuldingStatus_", "وضعیت");
            dictionary.Add("xArea", "متراژ");
            dictionary.Add("xZone", "منطقه");
            dictionary.Add("xGenPosition_", "موقعیت ابعادی");
            dictionary.Add("xlength", "طول");
            dictionary.Add("xWidth", "عرض");
            dictionary.Add("xGenContractType_", "نوع قرارداد");
            dictionary.Add("xLicenseRebuilding", "مجوز بازسازی");
            dictionary.Add("xLicenseRebuildingComment", "وضعیت مجوز بازسازی");
            dictionary.Add("xProductionLicense", "مجوز ساخت");
            dictionary.Add("xProductionLicenseComment", "وضعیت مجوز ساخت");
            dictionary.Add("xBuildingUnitsNumber", "تعداد واحد ساختمان");
            dictionary.Add("xFloorsNumber", "تعداد طبقه");
            dictionary.Add("xBuildingUnitsNumberRequest", "تعداد واحد مورد درخواست");
            dictionary.Add("xUnitID", "شماره واحد");
            dictionary.Add("xUnitArea", "مساخت واحد");
            dictionary.Add("xAreaRebuilding", "متراژ ساختمان");
            dictionary.Add("xBuildingYear", "سال ساخت");
            dictionary.Add("xBedroomsNumber", "تعداد اتاق خواب");
            dictionary.Add("xBathroomNumber", "تعداد حمام");
            dictionary.Add("xToiletNumber", "تعداد دستشویی");
            dictionary.Add("xGenRoof_", "سقف");
            dictionary.Add("xGenBuildingSkeleton_", "اسکلت ساختمان");
            dictionary.Add("xGenFoundation_", "فنداسیون");
            dictionary.Add("xGenWall_", "دیوار");
            dictionary.Add("xGenWaterPiping_", "لوله کشی آب");
            dictionary.Add("xGenGasPiping_", "لوله کشی گاز");
            dictionary.Add("xGenCoolingSystem_", "سیستم سرمایش");
            dictionary.Add("xGenHeatingSystem_", "سیستم گرمایش");
            dictionary.Add("xGenFlooring_", "کف");
            dictionary.Add("xGenKitchenWall_", "دیوار آشپزخانه");
            dictionary.Add("xGenKitchenFloor_", "کف آشپرخانه");
            dictionary.Add("xGenKitchenCupboards_", "کابینت آشپزخانه");
            dictionary.Add("xGenBathroomPiping_", "لوله کشی حمام");
            dictionary.Add("xBathtub", "وان");
            dictionary.Add("xBathTile", "کاشی حمام");
            dictionary.Add("xGenReasonsRebuilding_", "علت بازسازی");

            dictionary.Add("xBedroomsNumber_Ch", " تعداد اتاق خواب درخواستی");
            dictionary.Add("xBathroomNumber_Ch", "تعداد حمام درخواستی");
            dictionary.Add("xToiletNumber_Ch", "تعداد دستشویی درخواستی ");
            dictionary.Add("xGenRoof_Ch_", "سقف درخواستی");
            dictionary.Add("xGenBuildingSkeleton_Ch_", "اسکلت ساختمان درخواستی");
            dictionary.Add("xGenFoundation_Ch_", "فنداسیون درخواستی");
            dictionary.Add("xGenWall_Ch_", "دیوار درخواستی");
            dictionary.Add("xGenWaterPiping_Ch_", "لوله کشی آب درخواستی");
            dictionary.Add("xGenGasPiping_Ch_", "لوله کشی گازدرخواستی");
            dictionary.Add("xGenCoolingSystem_Ch_", "سیستم سرمایش درخواستی");
            dictionary.Add("xGenHeatingSystem_Ch_", "سیستم گرمایش درخواستی");
            dictionary.Add("xGenFlooring_Ch_", "کف درخواستی");
            dictionary.Add("xGenKitchenWall_Ch_", "دیوار آشپزخانه درخواستی");
            dictionary.Add("xGenKitchenFloor_Ch_", "کف آشپرخانه درخواستی");
            dictionary.Add("xGenKitchenCupboards_Ch_", "درخواستی کابینت آشپزخانه");
            dictionary.Add("xGenBathroomPiping_Ch_", "لوله کشی حمام درخواستی");
            dictionary.Add("xBathtub_Ch", "وان درخواستی");
            dictionary.Add("xBathTile_Ch", "کاشی حمام درخواستی");

            dictionary.Add("xGenSex_", "جنسیت");

            dictionary.Add("xParkingNumber", "تعداد پارکینگ");
            dictionary.Add("xStorageNumber", "تعداد انباری");
            dictionary.Add("xRoofGarden", "روف گاردن");

            dictionary.Add("xLicenseRenovation", "مجوز نوسازی");
            dictionary.Add("xLicenseRenovationComment", "توضیحات مجوز نوسازی");
            dictionary.Add("xNeighborUnitCount", "تعداد همسایه ها");
            dictionary.Add("xNeighborsLivingNumber", "تعداد همسایه های ساکن");

            dictionary.Add("xLength", "طول");
            dictionary.Add("xUnitNumber", "شماره واحد");

            dictionary.Add("xJacuzzi", "جکوزی");
            dictionary.Add("xSauna", "سونا");
            dictionary.Add("xGenJob_", "حیطه کاری");


            dictionary.Add("xScore", "امتیاز");
            dictionary.Add("xGenEvaluationName_", "مورد ارزیابی");

            dictionary.Add("xChildNo", "تعداد فرزند");
            dictionary.Add("xEmploy", "شغل");
            dictionary.Add("xGenIntroductionMethod_", "نحوه اشنایی");
            dictionary.Add("xGenFaith_", "اعتقادات");

            dictionary.Add("xAddress", "ادرس");

            dictionary.Add("xFatherName", "نام پدر");
            dictionary.Add("xNationalCode", "کد ملی");
            dictionary.Add("xBirthDay", "تاریخ تولد");

            dictionary.Add("xQuestion", "سوالات");
            dictionary.Add("xGenType_", "نوع");
            dictionary.Add("xGenGroupLevel1_", "سطح یک");
            dictionary.Add("xGenGroupLevel2_", "سطح دو");
            dictionary.Add("xOrder", "ترتیب");
            dictionary.Add("xActive", "فعال");
            dictionary.Add("xQuestionItem", "گزینه ها");

            dictionary.Add("xDate", "تاریخ");
            dictionary.Add("xComment", "توضیحات");
            dictionary.Add("xSupplier_", "ثبت کننده");
            dictionary.Add("xGenStatus_", "وضعیت");

            dictionary.Add("xQestionContext", "شرح ");
            dictionary.Add("xQuestionItem_", "گزینه");
            dictionary.Add("xQuestion_", "سوال");
            dictionary.Add("xPublic", "عمومی");

            dictionary.Add("xGenQUESTLEVL1_", "نوع پروژه");

            dictionary.Add("xGenUsage_", "نوع کاربری");
            dictionary.Add("xFloorNumber", "تعداد طبقه");
            dictionary.Add("xConstractionState_", "مرحله ساخت");
            dictionary.Add("xBuildingLicenseDate", "تاریخ پروانه ساخت");
            dictionary.Add("xBuildingOwner", "مالک ساختمان");
            dictionary.Add("xBuildingOwnerTel", "تلفن مالک");
            dictionary.Add("xContractor", "پیمانکار");
            dictionary.Add("xContractorTel", "تلفن پیمانکار");
            dictionary.Add("xSiteManegerTel", "تلفن مدیر سایت");
            dictionary.Add("xGuardName", "نام نگهبان");
            dictionary.Add("xGuardTel", "تلفن نگهبان");
            dictionary.Add("xInterViewer", "مصاحبه شوند");
            dictionary.Add("xInterViewerJob", "سمت");
            dictionary.Add("xInterViewerTel", "تلفن مصاحبه شونده");
            dictionary.Add("xDesignService", "خدمات طراحی");
            dictionary.Add("xBulidingTypeService_", "نوع خدمات املاک");
            dictionary.Add("xKitchen", "آشپزخانه");
            dictionary.Add("xWallCoverings", "پوشش های دیواری");
            dictionary.Add("xFloorCoverings", "پوشش های کف");
            dictionary.Add("xFacilities", "تاسیسات");
            dictionary.Add("xWoodenProducts", "درب و محصولات چوبی");
            dictionary.Add("xStoneAndBricks", "سنگ و سرامیک");
            dictionary.Add("xDecorationInside", "تزیینات ساختمان");
            dictionary.Add("xConcrete", "بتن");
            dictionary.Add("xOtherService", "خدمات دیگر");
            dictionary.Add("xIntroductionFor", "معرفی نامه جهت");
            dictionary.Add("xIntroductionCode", "کد معرف");
            dictionary.Add("xRegisterDate", "تاریخ ثبت");

            dictionary.Add("xTime", "زمان");
            dictionary.Add("xClientReferral", "مراجعه کننده");
            dictionary.Add("xTel", "تلفن");
            dictionary.Add("xRequestedGoods", "کالای درخواستی");
            dictionary.Add("xAmount", "مقدار");

            dictionary.Add("xResultOfReferral", "نتیجه مراجعه");


            dictionary.Add("xName", "نام");
            dictionary.Add("xCode", "کد");
            dictionary.Add("xGenGroup_", "گروه");
            dictionary.Add("xGenUnit_", "واحد");


            dictionary.Add("xBusinessNumber", "شماره اقتصادی  ");
            dictionary.Add("xRegistrationNumber", "شماره ثبت  ");
            dictionary.Add("xFax", "فکس  ");
            dictionary.Add("xZipCode", "کد پستی  ");

            dictionary.Add("xWebsite", "سایت  ");
            dictionary.Add("xSupplyManager", "مدیر تامین  ");
            dictionary.Add("xSupplyManagerTel", "تلفن مدیر تامین  ");
            dictionary.Add("xDirectorFactor", "مدیر عامل  ");
            dictionary.Add("xDirectorFactorTel", "تلفن مدیر عامل  ");
            dictionary.Add("xGrade", "گرید  ");
            dictionary.Add("xGradeDate", "تاریخ گرید  ");
            dictionary.Add("xSerial", "سریال  ");
            dictionary.Add("xEvaluationPerson", "شخص ارزیاب  ");

            dictionary.Add("xFieldActivity", "زمینه فعالیت");
            dictionary.Add("xEmail", "ایمیل");


            dictionary.Add("xGoods_", "محصول");
            dictionary.Add("xCompany_", "شرکت");
            dictionary.Add("xBrand", "برند");
            dictionary.Add("xOrderSupplyPeriod", "دوره تامین سفارش");
            dictionary.Add("xSettlementType", "نوع تسویه حساب");
            dictionary.Add("xContractType", "نوع قرارداد");
            dictionary.Add("xLastSupplierGrade", "اخرین گرید تامین کننده");
            dictionary.Add("xMinimumInventoryRequired", "حداقل موجودی مورد نیاز");
            dictionary.Add("xSalesExpertName", "نام کارشناس فروش");
            dictionary.Add("xSalesExpertNameAlternatives", "نام کارشناس فروش جایگزین");

            dictionary.Add("xCustomer_", "مشتری");
            dictionary.Add("xCompanyCustomer_", "مشتری");
            dictionary.Add("xCustomerTitle", "عنوان مشتری");
            dictionary.Add("xSupplierCompany", "شرکت تامین کننده");
            dictionary.Add("xAmunt", "مقدار");
            dictionary.Add("xPrice", "قیمت - ریال");
            dictionary.Add("xSellerUser_", "کارشناس فروش");
            dictionary.Add("xIntroduced", "معرف");
            //            xDate, xCustomer_, xCustomerTitle, xGoods_, xSupplierCompany, xBrand, xAmunt, xPrice, xGenStatus_, xSellerUser_, xIntroduced, xSupplier_, xComment

            dictionary.Add("xDeliveryDayNumber", "مدت زمان تحویل - روز");

            dictionary.Add("xGoodsCode", "کد کالا");
            dictionary.Add("xGoodsContext", "شرح کالا");
            dictionary.Add("xDiscount", "تخفیف");
            dictionary.Add("xUnits", "واحد");

            dictionary.Add("xRegisterTime", "زمان ثبت");

            dictionary.Add("xGenFollowUp_", "نوع پیگیری");


            dictionary.Add("xGenCUSTOMERTYPE_", "نوع مشتری");


            dictionary.Add("xUser_", "نام کاربر");
            dictionary.Add("xContext", "متن");
            dictionary.Add("xResult", "نتیجه");

            dictionary.Add("xContractDate", "تاریخ قرارداد");
            dictionary.Add("xContractNumber", "شماره قرارداد");
            dictionary.Add("xGenBuildingType_", "نوع ملک ");
            dictionary.Add("xBuildingAddress", "ادرس ملک ");
            dictionary.Add("xContractConsultant", "مشاور قرارداد");
            dictionary.Add("xContractManager", "مدیر قرارداد");
            dictionary.Add("xLessorName", "نام موجر");
            dictionary.Add("xLessorAddress", "ادرس موجر");
            dictionary.Add("xLessorNationalCode", "کد ملی موجر");
            dictionary.Add("xLessorTel", "تلفن موجر");
            dictionary.Add("xLessorEarnestCommission", "بیعانه کمیسیون موجر");
            dictionary.Add("xLessorCommission", "کمیسیون دریافتی موجر");
            dictionary.Add("xTenantName", "نام مستاجر");
            dictionary.Add("xTenantAddress", "ادرس مستاجر");
            dictionary.Add("xTenantNationalCode", "کد ملی مستاجر");
            dictionary.Add("xTenantTel", "تلفن مستاجر");
            dictionary.Add("xTenantEarnestCommission", "بیعانه کمیسیون مستاجر");
            dictionary.Add("xTenantCommission", "کمیسیون دریافتی مستاجر");
            dictionary.Add("xMortgage", "مبلغ رهن-ریال");
            dictionary.Add("xRent", "مبلغ اجاره-ریال");


            dictionary.Add("xSellerName", "نام فروشنده");
            dictionary.Add("xSellerAddress", "ادرس فروشنده");
            dictionary.Add("xSellerNationalCode", "کد ملی فروشنده");
            dictionary.Add("xSellerTel", "تلفن فروشنده");
            dictionary.Add("xSellerEarnestCommission", "بیعانه کمیسیون فروشنده");
            dictionary.Add("xSellerCommission", "کمیسیون دریافتی فروشنده");
            dictionary.Add("xBuyerName", "نام خریدار");
            dictionary.Add("xBuyerAddress", "ادرس خریدار");
            dictionary.Add("xBuyerNationalCode", "کد ملی خریدار");
            dictionary.Add("xBuyerTel", "تلفن خریدار");
            dictionary.Add("xBuyerEarnestCommission", "بیعانه کمیسیون دریافتی خریدار");
            dictionary.Add("xBuyerCommission", "کمیسیون دریافتی خریدار");


            dictionary.Add("MoonNumber", "شماره ماه");
            dictionary.Add("MoonName", " نام ماه");
            dictionary.Add("Sale", "فروش ");
            dictionary.Add("SaleFileCount", " تعداد فایل فروش");
            dictionary.Add("SaleCount", " تعداد قرارداد فروش");
            dictionary.Add("Rent", "رهن و اجاره ");
            dictionary.Add("RentFileCount", "تعداد فابل رهن و اجاره");
            dictionary.Add("RentCount", " تعداد قرارداد رهن و اجاره");

            dictionary.Add("FileCount", "تعداد فایل ");

            dictionary.Add("tanzimer", "تنظیم کننده ");

            dictionary.Add("xGenResultOfReferral_", " نتیجه مراجعه ");
            dictionary.Add("xAction", "اقدامات");

            dictionary.Add("xConstructionStage", "مرحله ساخت");
            dictionary.Add("xMasterFollowUp", "کارشناس پیگیری");

            dictionary.Add("xTaxLessorCommission", "ارزش افزوده اتحادیه موجر");
            dictionary.Add("xTaxTenantCommission", "ارزش افزوده اتحادیه مستاجر");
            dictionary.Add("xSumLessorAndTenantCommission", " مجموع کمیسیون موجر و مستاجر ");
            dictionary.Add("xSumTaxLessorAndTenantCommission", "ارزش افزوده مجموع کمیسیون موجر و مستاجر");
            dictionary.Add("xSumTotalByTaxLessorAndTenantCommission", "مجموع کمیسیون موجر، مستاجر و ارزش افزوده");
            dictionary.Add("xGuildCommission", "کمیسون اتحادیه");

            dictionary.Add("xHomeDeliveryDate", "تاریخ تحویل خانه ");
            dictionary.Add("xContractEndDate", " تاریخ پایان قرارداد");
            dictionary.Add("xFinancialApprove", "تایید مالی");
            dictionary.Add("xFinancialApprove_", "کاربر واحد مالی ");


            dictionary.Add("xSellerCommissionTax", "ارزش افزوده کمیسیون فروشنده");
            dictionary.Add("xBuyerCommissionTax", "ارزش افزوده کمیسیون خریدار");
            dictionary.Add("xBuyerANDSellerCommissionTax", "ارزش افزوده کمیسیون خریداروفروشنده");

            dictionary.Add("xDocumentTransferDate", "تاریخ انتقال سند");

            dictionary.Add("Name", "نام");
            dictionary.Add("InPerson", "حضوری");
            dictionary.Add("Divar", "دیوار");
            dictionary.Add("Other", "دیگر");
            dictionary.Add("TotalWeekFile", " کل فایل جاری بازه زمانی");
            dictionary.Add("BeforWeekFile", "کل فایل های ارشیو و جاری قبل");
            dictionary.Add("DeleteCurrentWeekFile", "فایل های ارشیو بازه زمانی");
            dictionary.Add("TotalFile", "کل فایل های  سیستم");
            dictionary.Add("TotalFileDelete", "کل فایل های ارشیو  سیستم");
            dictionary.Add("TotalBuyer", "کل خریداران");
            dictionary.Add("TotalContract", "تعداد قراردادها");
            dictionary.Add("PercentSellOnDemand", "درصد به مراجعه کننده");
            dictionary.Add("xGenReferTo_", "ارجاع به");
            dictionary.Add("xReferConfirm", "تایید ارجاع");
            dictionary.Add("xReferConfirmSupplier_", "تایید کننده ارجاع ");
            dictionary.Add("xReferConfirmDate", "تاریخ تایید ارجاع");
            dictionary.Add("xContractPrice", "مبلغ قرارداد");
            dictionary.Add("xRecommenderCommission", "سهم معرف");
            dictionary.Add("xReferFinanceConfirm", "تایید مالی");
            dictionary.Add("xAnswerContext", "جواب سوال");
            dictionary.Add("xAnswerContextCount", "تعداد");
            dictionary.Add("xReferName", "نام معرف");
            dictionary.Add("xContractConsultantCount", "تعداد قرارداد");

            dictionary.Add("TotalCommission", "مجموع کمیسیون ");


            dictionary.Add("xConsultant_", " نام مشاور");
            dictionary.Add("xFileNumber", "شماره فایل ");
            dictionary.Add("xFileDate", " تاریخ ثبت فایل");
            dictionary.Add("xBuildingOwnerName", " نام مالک");
            dictionary.Add("xFailureConcludeContract", " دلیل عدم انعقاد قرارداد");
            dictionary.Add("xFollowUpDate", " تاریخ پیگیری");
            dictionary.Add("xFollowUpType", " نوع پیگیری");
            dictionary.Add("xGenFollowUpFinalResult_", " نتیجه نهایی پیگیری");
            dictionary.Add("xFollowUpFinalResult", " دلیل ارجاع");
            dictionary.Add("xSuggestedItems", "آیتم های پیشنهادی ");
            dictionary.Add("xSoldItems", "آیتم های به فروش رسیده ");
            dictionary.Add("xContractCost", "مبلغ قرارداد ");
            dictionary.Add("xConsultantCommission", " سهم مشاور");
            dictionary.Add("xSupplierReferFinanceConfirm_", "کاربر مالی ");
            dictionary.Add("xFollowUpComment", " توضیحات");

            dictionary.Add("xGenEducation_", "تحصیلات");
            dictionary.Add("xGenMarital_", "تاهل");
            dictionary.Add("xChildNumberBoys", "تعداد فرزندان پسر");
            dictionary.Add("xChildNumberGirls", "تعداد فرزندان دختر");
            dictionary.Add("xJob", "شغل");
            dictionary.Add("xWorkAddress", "ادرس محل کار");
            dictionary.Add("xRenovationActivity", "فعالیت نوسازی");
            dictionary.Add("xRebuildingActivity", "فعالیت بازسازی");
            dictionary.Add("xExperience", "سابقه کار - سال");
            dictionary.Add("xActivityMethodPersonal", "فعالیت شخصی");
            dictionary.Add("xActivityMethodCollaborative", "فعالیت مشارکتی");
            dictionary.Add("xActivityMethodCorporate", "فعالیت شرکتی");
            dictionary.Add("xActivityMethodManagementContract", "فعالیت پیمان مدیریتی");
            dictionary.Add("xGenAnnualActivityVolume_", "حجم فعالیت سالانه");
            dictionary.Add("xBusinessPriorityEarning", "اولویت تجاری کسب درامد");
            dictionary.Add("xBusinessPriorityBranding", "اولویت تجاری  برندسازی");
            dictionary.Add("xBusinessPriorityCompetitive", "اولویت تجاری  رقابتی");
            dictionary.Add("xBusinessPriorityDevelopment", "اولویت تجاری  توسعه");
            dictionary.Add("xGenAbilitiesBuyAndSell_", "تخصص خرید و فروش");
            dictionary.Add("xGenAbilitiesDesigning_", "طراحی");
            dictionary.Add("xGenAbilitiesImplementation_", "اجرا");
            dictionary.Add("xGenAbilitiesSupply_", "تامین متریال");
            dictionary.Add("xGenAbilitiesPermissions_", "اخذ مجوزات");
            dictionary.Add("xCollaborationPeriod", "مدت همکاری");
            dictionary.Add("xCooperation", "زمینه همکاری");
            dictionary.Add("xCollaborationResult", "نتایج همکاری");

            dictionary.Add("xFloorCount", "تعداد طبقه");
            dictionary.Add("xGenQualityStatus", "کیفیت");
            dictionary.Add("xStartYear", "سال شروع");
            dictionary.Add("xEndYear", "سال پایان");
            dictionary.Add("xDatetime", "تاریخ");
            dictionary.Add("xProjectStage", "مرحله پروژه");

            dictionary.Add("xFamily", "نام خانوادگی");

            dictionary.Add("xPossibleNeeds", "نیاز های احتمالی");
            dictionary.Add("xTimeForecast", "پیش بینی زمان به روز");
            dictionary.Add("xInChargeOfTheFollowUp", "مسئول پیگیری وارتباط");
            dictionary.Add("xFollowUpMethod", "روش پیگیری");

            dictionary.Add("xObtainedResult", "نتایج حاصله");
            dictionary.Add("xReasonsNotAchievingOrAchievingResults", "دلایل عدم حصول و یا حصول نتایج");
            dictionary.Add("xGenFollowUpNeedResult_", "نتیجه");




            if (dictionary.ContainsKey(StInput))
            {
                string value = dictionary[StInput];
                return value;
            }

            return InsertSpace(StInput.Substring(1)).TrimEnd('_');
        }
    }
}
