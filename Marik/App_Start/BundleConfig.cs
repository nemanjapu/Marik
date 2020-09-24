using System.Web;
using System.Web.Optimization;

namespace Marik
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*ADMIN BUNDLES*/

            bundles.Add(new ScriptBundle("~/bundles/AdminScripts").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/jquery.validate*",
                       "~/Scripts/jquery.unobtrusive-ajax.js",
                       "~/Scripts/jquery-ui-1.12.1.js",
                       "~/Areas/Admin/Content/js/popper.min.js",
                       "~/Areas/Admin/Content/js/tether.min.js",
                       "~/Areas/Admin/Content/js/bootstrap.js",
                       "~/Areas/Admin/Content/js/pikeadmin.js",
                       "~/Areas/Admin/Content/js/moment.min.js",
                       "~/Areas/Admin/Content/js/detect.js",
                       "~/Areas/Admin/Content/js/fastclick.js",
                       "~/Areas/Admin/Content/js/jquery.blockUI.js",
                       "~/Areas/Admin/Content/js/jquery.nicescroll.js",
                       "~/Areas/Admin/Content/js/switchery.min.js",
                       "~/Areas/Admin/Content/js/select2.js",
                       "~/Areas/Admin/Content/js/select2-init.js",
                       "~/Scripts/summernote/summernote.js",
                       "~/Scripts/toastr.js",
                       "~/Areas/Admin/Content/js/adminGlobal.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/AdminCSS").Include(
                        "~/Areas/Admin/Content/css/bootstrap.css",
                        "~/Areas/Admin/Content/css/switchery.css",
                        "~/Content/themes/base/jquery-ui.css",
                        "~/Scripts/summernote/summernote.css",
                        "~/Areas/Admin/Content/css/jquery.filer-dragdropbox-theme.css",
                        "~/Areas/Admin/Content/css/style.css",
                        "~/Areas/Admin/Content/css/select2.css",
                         "~/Content/toastr.css"
                        ));

            bundles.Add(new StyleBundle("~/Content/admin/FontAwesomeCss").Include(
                        "~/Areas/Admin/Content/css/font-awesome.css", new CssRewriteUrlTransform()
                        ));

            bundles.Add(new ScriptBundle("~/bundles/blogAdminScript").Include(
                        "~/Areas/Admin/Content/js/blog-script.js"
                       ));

            /*EDITOR BUNDLES*/
            bundles.Add(new ScriptBundle("~/bundles/EditorScripts").Include(
                      "~/Scripts/summernote/summernote.js",
                      "~/Areas/Editor/Content/js/editor.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/editor/EditorCss").Include(
                        "~/Scripts/summernote/summernote.css",
                        "~/Areas/Editor/Content/css/editor.css"
                        ));

            /*USER BUNDLES*/

            bundles.Add(new StyleBundle("~/Content/UserCSS").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/owl.carousel.css",
                       "~/Content/owl.theme.default.css",
                       "~/Content/style.css"
                       ).Include(
                       "~/Content/fontawesome-all.css", new CssRewriteUrlTransform()));

            //bundles.Add(new StyleBundle("~/Content/UserCSS").Include(
            //           "~/Content/userCss.css"
            //           ));

            bundles.Add(new ScriptBundle("~/bundles/UserScripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/umd/popper.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/userScripts/owl.carousel.js",
                        "~/Scripts/userScripts/global.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/homeScripts").Include(
                        "~/Scripts/userScripts/home.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/aboutScripts").Include(
                        "~/Scripts/userScripts/about.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/productScripts").Include(
                        "~/Scripts/userScripts/product.js"
                       ));


            BundleTable.EnableOptimizations = true;
        }
    }
}
