using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        public object TestSettings { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {

            var Options = new BrowserOptions
            {
                BrowserType = BrowserType.Chrome,
                PrivateMode = true
            };

            var username = "COGTIT622@firjan.com.br";

            var password =                                                                                                                                      "Cruzeiro@5428";

            var xrmUri = new Uri("https://firjan-hom.crm2.dynamics.com/main.aspx?appid=7632e659-1889-e911-a954-000d3ac03470&pagetype=entitylist&etn=firjan_hierarquiadeproduto&viewid=35f5fe77-153b-4f03-a49b-6091bd887ad9&viewType=1039");

            var client = new WebClient(Options);

            using (var xrmApp = new XrmApp(client))

            {
                xrmApp.OnlineLogin.Login(xrmUri, username.ToSecureString(), password.ToSecureString());

                xrmApp.Navigation.OpenSubArea("Contas Contábeis");

                xrmApp.Grid.Search("41020304028");

                xrmApp.Grid.OpenRecord(0);

                xrmApp.Entity.SelectTab("Relacionados", "Contas Contábeis x Produtos");

                xrmApp.Navigation.QuickCreate("Exportar Contas Contábeis x Produtos");



                xrmApp.Navigation.OpenSubArea("Unidades Executoras");

                xrmApp.Navigation.QuickCreate("Criar");

                /*xrmApp.Entity.SetValue("input[aria-label='Unidade, Pesquisa']", "Teste");*/

                xrmApp.Navigation.QuickCreate("Salvar");

                xrmApp.Navigation.OpenSubArea("Contas Contábeis");


                xrmApp.ThinkTime(2000);
            }


        }

    }


}
