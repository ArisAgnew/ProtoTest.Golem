﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Golem.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Golem.PageObjects.Emcon.FMX
{
    public class FMX_Jobs_JobRequest_WorkOrders : FMX_Jobs_JobRequests
    {
        Element CreateNewWorkOrder = new Element("CreateNewWorkOrder", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrder_lbtnNew"));
        Element CreateNewWOPop = new Element("NewWorkOrderPOP", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_pnlPopupGenerateWorkOrder"));
        
        Element CreateNewWOCalendar = new Element("NewWorkOrderCalendar", By.XPath("//*[@id='ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_pnlPopupGenerateWorkOrderContent']/div/img"));
        Element CreateNewWO_NextMonth = new Element("NewWorkOrderCal_nextMonth", By.XPath("//*[@id='ui-datepicker-div']/div/a[2]/span"));
        Element CreateNewWO_FirstDay = new Element("FirstDayWeekTwo", By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[2]/td[2]/a"));
        Element GenerateWO = new Element("GenerateWO", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_btnGenerate"));

        Element SendPrintWO = new Element("SendPrintWO", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrder_lbtnSend"));
        Element SendWOPop = new Element("SendWOPop", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_pnlPopUpDocumentPicker"));
        Element SendPrintWOPopButton = new Element("SendPrintWOPopButton", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_lbtnSend"));
        Element SendWORequestPOP = new Element("SendWORequestPOP", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_ucDocumentSend_pnlPopupDocumentSend"));

        Element EmailAddress = new Element("EmailAddress", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_ucDocumentSend_txtNewEmail"));
        Element SelectEmailAddress = new Element("SelectEmailAddress", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_ucDocumentSend_clstNewEmail_0"));
        Element PrintWORequest = new Element("PrintWORequest", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_ucDocumentSend_chkPrint"));

        Element SendDocument = new Element("SendDocument", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_ucDocumentSend_btnSendDocument"));

        Element EditWODetail = new Element("EditWODetail", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrderDetail_lbtnEdit"));
        Element WorkStartDateCalendar = new Element("WorkStartDate", By.XPath("//*[@id='ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrderDetail']/tbody/tr/td/table/tbody/tr/td[2]/img"));
        Element WorkStartDate = new Element("WorkStartDate", By.ClassName("ui-state-highlight"));
        Element EditWOSave = new Element("EditWOSave", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrderDetail_lnkSave"));

        Element EditWOHeader = new Element("EditWOHeader", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvWorkOrder_lbtnEdit"));
        Element CallOutCome = new Element("CallOutCome", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_ddCallOutcome"));
        Element JobSatisfactory = new Element("JobSatisfactory", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_rblSatisfactory_0"));
        Element ManagerFirstName = new Element("ManagerFirstName", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_txtFirstName"));
        Element ManagerLastName = new Element("ManagerLastName", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_txtLastName"));
        Element Notes = new Element("Notes", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_txtNotes"));
        Element CompletedCalendar = new Element("CompletedCalendar", By.XPath("//*[@id='ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_trJobCompleted']/td[2]/img"));
        Element SaveWorkOrder = new Element("SaveWorkORder", By.Id("ctl00_ContentPlaceHolder1_JobTabs_TabWO_UcJobWorkOrder_fvCloseJob_lbtnInsertClosing"));

        Element proposalsTab = new Element("ProposalsTab", By.Id("__tab_ctl00_ContentPlaceHolder1_JobTabs_TabProposals"));

        public FMX_Jobs_JobRequest_WorkOrders AddNewWorkOrder(string emailAddy, string bossFName, string bossLName, string someNotes)
        {
            CreateNewWorkOrder.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            CreateNewWOPop.WaitUntilVisible();
            CreateNewWOCalendar.WaitUntilVisible().Click();
            CreateNewWO_NextMonth.WaitUntilVisible().Click();
            CreateNewWO_FirstDay.WaitUntilVisible().Click();
            GenerateWO.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            CreateNewWOPop.WaitUntilNotVisible();
            SendPrintWO.WaitUntilVisible();
            int y = SendPrintWO.Location.Y;
            driver.JavaWindowScroll(0, y-HeaderBarHeight);
            SendPrintWO.Click();

            pleaseWait.WaitUntilNotVisible();
            SendWOPop.WaitUntilVisible();
            SendPrintWOPopButton.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            SendWORequestPOP.WaitUntilVisible();
            EmailAddress.WaitUntilVisible().Text = emailAddy;
            SelectEmailAddress.WaitUntilVisible().Click();  //this will select the third email address field or always the new email address field
            PrintWORequest.WaitUntilVisible().Click();
            SendDocument.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            SendWORequestPOP.WaitUntilNotVisible();
            EditWODetail.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            WorkStartDateCalendar.WaitUntilVisible().Click();
            WorkStartDate.WaitUntilVisible().Click();
            EditWOSave.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            EditWOHeader.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            driver.ExecuteJavaScript("__doPostBack('ctl00$ContentPlaceHolder1$JobTabs$TabWO$UcJobWorkOrder$fvWorkOrder$lbtnCloseJob', '')"); //ClickCloseJobLink
            //after here is a hidden frame -- but it's really not
            CallOutCome.WaitUntilPresent().FindElement(ByE.Text("Job Done")).Click();
            pleaseWait.WaitUntilNotVisible();
            JobSatisfactory.WaitUntilPresent().Click();
            pleaseWait.WaitUntilNotVisible();
            ManagerFirstName.WaitUntilPresent().Text = bossFName;
            ManagerLastName.WaitUntilPresent().Text = bossLName;
            Notes.WaitUntilPresent().Text = someNotes;
            CompletedCalendar.WaitUntilPresent().Click();
            WorkStartDate.WaitUntilPresent().Click();  //resused today element
            SaveWorkOrder.WaitUntilPresent().Click();
            driver.SwitchTo().Alert().Accept();
            pleaseWait.WaitUntilNotVisible();
            

            return new FMX_Jobs_JobRequest_WorkOrders();
        }

        public FMX_Jobs_JobRequest_Proposals ClickProposals()
        {
            proposalsTab.WaitUntilVisible().Click();
            pleaseWait.WaitUntilNotVisible();
            return new FMX_Jobs_JobRequest_Proposals();
        }
        
    }
}