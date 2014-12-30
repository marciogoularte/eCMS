﻿using Eagle.Core;
using Eagle.Model.SYS.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Eagle.Repository.SYS.Modules
{
    public class ModuleRepository
    {
       

        public EntityDataContext context { get; set; }

        public ModuleRepository(EntityDataContext context)
        {
            this.context = context;
        }

        //public JsonResult TreeData(FormCollection form)
        //{
        //    return GetTreeData(Request.QueryString["id"], Request.QueryString["uitype"]);
        //}

        //public List<Role> GetModuleRolePermissions()
        //{
        //    using (EntityDataContext context = new EntityDataContext())
        //    {
        //        List<ModuleRolePermissionViewModel> lst = new List<ModuleRolePermissionViewModel>();
        //        lst = (from p in context.Roles
        //               select new ModuleRolePermissionViewModel
        //               {
        //                   ApplicationId = p.ApplicationId,
        //                   ContentItemId = p.ContentItemId,
        //                   ModuleId = p.ModuleId,
        //                   ModuleCode = p.ModuleCode,
        //                   ModuleKey = p.ModuleKey,
        //                   ModuleTitle = p.ModuleTitle,
        //                   ModuleName = p.ModuleName,
        //                   AllTabs = p.AllTabs,
        //                   IsAdmin = p.IsAdmin,
        //                   IsDeleted = p.IsDeleted,
        //                   InheritViewPermissions = p.InheritViewPermissions,
        //                   Header = p.Header,
        //                   Footer = p.Footer,
        //                   StartDate = p.StartDate,
        //                   EndDate = p.EndDate,
        //                   Pane = p.Pane,
        //                   InsertedPosition = p.InsertedPosition,
        //                   Visibility = p.Visibility,
        //                   Alignment = p.Alignment,
        //                   Border = p.Border,
        //                   Color = p.Color,
        //                   Icon = p.Icon
        //               }).ToList();
        //        return lst;
        //    }
        //}


        #region Module Type List ======================================================================================
        public SelectList PopulateModuleTypeList(string SelectedValue, bool IsShowSelectText = false)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.NoneSpecified, Value = "0" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.New, Value = "1" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Control, Value = "2" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Manifest, Value = "3" });

            if (IsShowSelectText)
                lst.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
            return new SelectList(lst, "Value", "Text", SelectedValue);
        }
        #endregion ====================================================================================================

        #region Module List ======================================================================================

        public static SelectList PopulateAlignmentList(string SelectedValue, bool IsShowSelectText = false)
        {
            List<SelectListItem> lst = new List<SelectListItem>();          
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Left, Value = "Left" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Center, Value = "Center" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Right, Value = "Right" });
            if (IsShowSelectText)
                lst.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
            return new SelectList(lst, "Value", "Text", SelectedValue);
        }

        public static SelectList PopulateInsertedPositionList(string SelectedValue, bool IsShowSelectText = false)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Top, Value = "Top" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Bottom, Value = "Bottom" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Left, Value = "Left" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.Right, Value = "Right" });
            if (IsShowSelectText)
                lst.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
            return new SelectList(lst, "Value", "Text", SelectedValue);
        }

        
        public static SelectList PopulateVisibilityList(string SelectedValue, bool IsShowSelectText = false)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.SameAsPage, Value = "1" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.PageEditorsOnly, Value = "0" });
            if (IsShowSelectText)
                lst.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
            return new SelectList(lst, "Value", "Text", SelectedValue);
        }
        public static SelectList PopulatePaneList(string SelectedValue, bool IsShowSelectText = false)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.ContentPane, Value = "ContentPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.TopPane, Value = "TopPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.LeftPane, Value = "LeftPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.RightPane, Value = "RightPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.BottomPane, Value = "BottomPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.BannerPane, Value = "BannerPane" });
            lst.Add(new SelectListItem { Text = Resource.LanguageResource.LogoPane, Value = "LogoPane" });

            if (IsShowSelectText)
                lst.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
            return new SelectList(lst, "Value", "Text", SelectedValue);
        }
        
        public static SelectList PopulateModuleList(string SelectedValue, bool IsShowSelectText = false)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                List<SelectListItem> list = (context.Modules.AsEnumerable().Select(p => new SelectListItem()
                {
                    Text = p.ModuleTitle,
                    Value = p.ModuleId.ToString()
                })).ToList();


                if (IsShowSelectText)
                    list.Insert(0, new SelectListItem { Text = string.Format("--- {0} ---", Eagle.Resource.LanguageResource.Select), Value = "" });
                return new SelectList(list, "Value", "Text", SelectedValue);
            }
        }
        #endregion ====================================================================================================

        public List<ModuleViewModel> GetModuleList()
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                List<ModuleViewModel> lst = new List<ModuleViewModel>();
                lst = (from p in context.Modules
                       select new ModuleViewModel
                       {
                           ApplicationId = p.ApplicationId,
                           ContentItemId = p.ContentItemId,
                           ModuleId = p.ModuleId,
                           ModuleCode = p.ModuleCode,
                           ModuleKey = p.ModuleKey,
                           ModuleTitle = p.ModuleTitle,
                           ModuleName = p.ModuleName,
                           AllTabs = p.AllTabs,
                           IsAdmin = p.IsAdmin,
                           IsDeleted = p.IsDeleted,
                           InheritViewPermissions = p.InheritViewPermissions,
                           Header = p.Header,
                           Footer = p.Footer,
                           StartDate = p.StartDate,
                           EndDate = p.EndDate,
                           Visibility = p.Visibility
                       }).ToList();
                return lst;
            }
        }

        public bool IsIdExisted(int ModuleId)
        {
            var query = context.Modules.FirstOrDefault(p => p.ModuleId.Equals(ModuleId));
            return (query != null);
        }

        public bool IsKeyExisted(string ModuleKey)
        {
            var query = context.Modules.FirstOrDefault(p => p.ModuleKey.Equals(ModuleKey));
            return (query != null);
        }

        public static List<ModuleViewModel> GetList(bool IsAdmin)
        {
            using(EntityDataContext context = new EntityDataContext())
            {
                List<ModuleViewModel> lst = new List<ModuleViewModel>();
                lst = (from c in context.Modules
                       select new ModuleViewModel()
                       {
                           ApplicationId = c.ApplicationId,
                           ContentItemId = c.ContentItemId,
                           ModuleId = c.ModuleId,
                           ModuleCode = c.ModuleCode,
                           ModuleKey = c.ModuleKey,
                           ModuleTitle = c.ModuleTitle,
                           ModuleName = c.ModuleName,
                           AllTabs = c.AllTabs,
                           IsAdmin = c.IsAdmin,
                           IsDeleted = c.IsDeleted,
                           InheritViewPermissions = c.InheritViewPermissions,
                           Header = c.Header,
                           Footer = c.Footer,
                           StartDate = c.StartDate,
                           EndDate = c.EndDate
                       }).OrderByDescending(c => c.ModuleId).ToList();

                return lst;
            }            
        }

        public static List<ModuleViewModel> GetListByPageId(int PageId)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                List<ModuleViewModel> lst = new List<ModuleViewModel>();
                lst = (from pm in context.PageModules
                       join m in context.Modules on pm.ModuleId equals m.ModuleId into module_lst
                       from ml in module_lst.DefaultIfEmpty()
                       where pm.PageId == PageId
                       select new ModuleViewModel()
                       {
                           ApplicationId = ml.ApplicationId,
                           ContentItemId = ml.ContentItemId,
                           ModuleId = ml.ModuleId,
                           ModuleCode = ml.ModuleCode,
                           ModuleKey = ml.ModuleKey,
                           ModuleTitle = ml.ModuleTitle,
                           ModuleName = ml.ModuleName,
                           AllTabs = ml.AllTabs,
                           IsAdmin = ml.IsAdmin,
                           IsDeleted = ml.IsDeleted,
                           InheritViewPermissions = ml.InheritViewPermissions,
                           Header = ml.Header,
                           Footer = ml.Footer,
                           StartDate = ml.StartDate,
                           EndDate = ml.EndDate,
                           Pane = pm.Pane,
                           ModuleOrder = pm.ModuleOrder,
                           Alignment = pm.Alignment,
                           Color = pm.Color,
                           Border = pm.Border,
                           Icon = pm.Icon
                       }).OrderByDescending(pm => pm.ModuleOrder).ToList();

                return lst;
            }
        }
        public static List<ModuleViewModel> GetListByPageIdAndIsAdmin(int PageId, bool? IsAdmin)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                List<ModuleViewModel> lst = new List<ModuleViewModel>();
                lst = (from pm in context.PageModules
                       join m in context.Modules on pm.ModuleId equals m.ModuleId into module_lst
                       from ml in module_lst.DefaultIfEmpty()
                       where pm.PageId == PageId && (ml.IsAdmin == IsAdmin || IsAdmin == null)
                       select new ModuleViewModel()
                       {
                           ApplicationId = ml.ApplicationId,
                           ContentItemId = ml.ContentItemId,
                           ModuleId = ml.ModuleId,
                           ModuleCode = ml.ModuleCode,
                           ModuleKey = ml.ModuleKey,
                           ModuleTitle = ml.ModuleTitle,
                           ModuleName = ml.ModuleName,
                           AllTabs = ml.AllTabs,
                           IsAdmin = ml.IsAdmin,
                           IsDeleted = ml.IsDeleted,
                           InheritViewPermissions = ml.InheritViewPermissions,
                           Header = ml.Header,
                           Footer = ml.Footer,
                           StartDate = ml.StartDate,
                           EndDate = ml.EndDate,
                           Pane = pm.Pane,
                           ModuleOrder = pm.ModuleOrder,
                           Alignment = pm.Alignment,
                           Color = pm.Color,
                           Border = pm.Border,
                           Icon = pm.Icon
                       }).OrderByDescending(pm => pm.ModuleOrder).ToList();

                return lst;
            }
        }
        public static List<ModuleViewModel> GetListByKeywordsPageIdIsAdmin(string Keywords, int PageId, bool? IsAdmin)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                List<ModuleViewModel> lst = new List<ModuleViewModel>();
                lst = (from pm in context.PageModules
                       join m in context.Modules on pm.ModuleId equals m.ModuleId into module_lst
                       from ml in module_lst.DefaultIfEmpty()
                       where pm.PageId == PageId && (ml.IsAdmin == IsAdmin || IsAdmin == null)
                       && (ml.ModuleTitle == Keywords || Keywords == null) && (ml.ModuleKey == Keywords || Keywords == null)
                       select new ModuleViewModel()
                       {
                           ApplicationId = ml.ApplicationId,
                           ContentItemId = ml.ContentItemId,                          
                           ModuleId = ml.ModuleId,
                           ModuleCode = ml.ModuleCode,
                           ModuleKey = ml.ModuleKey,
                           ModuleTitle = ml.ModuleTitle,
                           ModuleName = ml.ModuleName,
                           AllTabs = ml.AllTabs,
                           IsAdmin = ml.IsAdmin,
                           IsDeleted = ml.IsDeleted,
                           InheritViewPermissions = ml.InheritViewPermissions,
                           Header = ml.Header,
                           Footer = ml.Footer,
                           StartDate = ml.StartDate,
                           EndDate = ml.EndDate,
                           Pane = pm.Pane,
                           ModuleOrder = pm.ModuleOrder,
                           Alignment = pm.Alignment,
                           Color = pm.Color,
                           Border = pm.Border,
                           Icon = pm.Icon
                       }).OrderByDescending(pm => pm.ModuleOrder).ToList();

                return lst;
            }
        }

        public static ModuleViewModel Details(int Id)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                ModuleViewModel entity = new ModuleViewModel();
                try
                {                   
                    entity = (from c in context.Modules
                              where c.ModuleId == Id
                              select new ModuleViewModel()
                              {
                                  ApplicationId = c.ApplicationId,
                                  ContentItemId = c.ContentItemId,
                                  ModuleId = c.ModuleId,
                                  ModuleCode = c.ModuleCode,
                                  ModuleKey = c.ModuleKey,
                                  ModuleTitle = c.ModuleTitle,
                                  ModuleName = c.ModuleName,
                                  AllTabs = c.AllTabs,
                                  IsAdmin = c.IsAdmin,
                                  IsDeleted = c.IsDeleted,
                                  InheritViewPermissions = c.InheritViewPermissions,
                                  Header = c.Header,
                                  Footer = c.Footer,
                                  StartDate = c.StartDate,
                                  EndDate = c.EndDate
                              }).FirstOrDefault();
                    
                }
                catch (Exception ex){ ex.ToString();}
                return entity;
            }
        }

        public static Module Find(int? ID)
        {
            using (EntityDataContext context = new EntityDataContext())
            {
                return context.Modules.Find(ID);
            }
        }

        public bool Insert(ModuleViewModel add_model, out string Message)
        {
            Message = string.Empty;
            bool result = false;
            try
            {
                bool flag = IsKeyExisted(add_model.ModuleKey);
                if (flag == false)
                {
                    Module model = new Module();
                    model.ApplicationId = add_model.ApplicationId;
                    model.ContentItemId = add_model.ContentItemId;
                    model.ModuleId = add_model.ModuleId;
                    model.ModuleCode = add_model.ModuleCode;
                    model.ModuleKey = add_model.ModuleKey;
                    model.ModuleTitle = add_model.ModuleTitle;
                    model.ModuleName = add_model.ModuleName;
                    model.AllTabs = add_model.AllTabs;
                    model.IsAdmin = add_model.IsAdmin;
                    model.IsDeleted = add_model.IsDeleted;
                    model.InheritViewPermissions = add_model.InheritViewPermissions;
                    model.Header = add_model.Header;
                    model.Footer = add_model.Footer;
                    model.StartDate = add_model.StartDate;
                    int affectedRow = 0;
                    context.Entry(model).State = System.Data.Entity.EntityState.Added;
                    affectedRow = context.SaveChanges();
                    if (affectedRow == 1)
                    {
                        add_model.ModuleId = model.ModuleId;
                        Message = Eagle.Resource.LanguageResource.CreateSuccess;
                        result = true;
                    }
                }
                else
                {
                    result = false;
                    Message = Eagle.Resource.LanguageResource.DuplicateError;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = false;
                Message = Eagle.Resource.LanguageResource.SystemError;
            }
            return result;
        }

        public bool Update(ModuleViewModel edit_model, out string Message)
        {
            Message = string.Empty;
            bool result = false;
            try
            {
                bool IdExisted = IsIdExisted(edit_model.ModuleId);
                if (IdExisted == true)
                {
                    Module model = Find(edit_model.ModuleId);
                    if (model != null)
                    {                    
                        model.ContentItemId = edit_model.ContentItemId;
                        model.ModuleId = edit_model.ModuleId;
                        model.ModuleCode = edit_model.ModuleCode;
                        model.ModuleKey = edit_model.ModuleKey;
                        model.ModuleTitle = edit_model.ModuleTitle;
                        model.ModuleName = edit_model.ModuleName;
                        model.AllTabs = edit_model.AllTabs;
                        model.IsAdmin = edit_model.IsAdmin;
                        model.IsDeleted = edit_model.IsDeleted;
                        model.InheritViewPermissions = edit_model.InheritViewPermissions;
                        model.Header = edit_model.Header;
                        model.Footer = edit_model.Footer;
                        model.StartDate = edit_model.StartDate;

                        context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                        int affectedRows = context.SaveChanges();
                        if (affectedRows == 1)
                        {
                            Message = Eagle.Resource.LanguageResource.UpdateSuccess;
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = false;
                Message = Eagle.Resource.LanguageResource.SystemError;
            }
            return result;
        }

        public bool Delete(int? id, out string message)
        {
            bool result = false;
            message = string.Empty;
            try
            {
                Module model = Find(id);
                if (model != null)
                {
                    context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    result = true;
                    message = Eagle.Resource.LanguageResource.DeleteSuccess;
                }
                else
                {
                    message = Eagle.Resource.LanguageResource.IDNoExistsErrorMessage;
                    result = false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = false;
                message = Eagle.Resource.LanguageResource.DeleteFailure;
            }

            return result;
        }
    }
}