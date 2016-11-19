﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wemtek.Domain.Entities;



namespace Wemtek.GUI.Helpers
{
    public static class ExtensionMethod
    {
        public static IEnumerable<SelectListItem>
            ToSelectListItems(this IEnumerable<company> numReal)
        {
            return numReal.OrderBy(c => c.Id).Select(r =>
                   new SelectListItem
                   {
                       Text = r.Name,
                       Value = r.Id.ToString()

                   }

            );
        }

         public static IEnumerable<SelectListItem>
            ToSelectCatPerProject(this IEnumerable<category> name)
        {
            return name.OrderBy(c => c.idCategory).Select(r =>
                   new SelectListItem
                   {
                       Text = r.name,
                       Value = r.idCategory.ToString()

                   }

            );
        }
    }
}