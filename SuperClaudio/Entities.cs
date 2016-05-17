﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperClaudio
{
    public class Entities
    {
        public static bool waitingAnswer = false;
        public static string subject = "";
        public Dictionary<string, string> EntitiesOfAzure = new Dictionary<string, string>
        {
            {"vm", "Virtual Machine" },
            {"mv", "Virtual Machine" },
            {"virtualmachine", "Virtual Machine" },
            {"virtual machine", "Virtual Machine" },
            {"máquina virtual", "Virtual Machine" },
            {"maquina virtual", "Virtual Machine" },
            {"maquinavirtual", "Virtual Machine" },
            {"serviço de aplicativo", "AppServices" },
            {"servico de aplicativo", "AppServices" },
            {"servicode aplicativo", "AppServices" },
            {"servico deaplicativo", "AppServices" },
            {"servicodeaplicativo", "AppServices" },
            {"servicos de aplicativo", "AppServices" },
            {"servicosde aplicativo", "AppServices" },
            {"servicos deaplicativo", "AppServices" },
            {"servicosdeaplicativo", "AppServices" },
            {"serviço de aplicativo", "AppServices" },
            {"serviçode aplicativo", "AppServices" },
            {"serviço deaplicativo", "AppServices" },
            {"serviçodeaplicativo", "AppServices" },
            {"serviços de aplicativo", "AppServices" },
            {"serviçosde aplicativo", "AppServices" },
            {"serviços deaplicativo", "AppServices" },
            {"serviçosdeaplicativo", "AppServices" },
            {"serviços de aplicativo", "AppServices" },
            {"serviços de aplicação", "AppServices" },
            {"serviçosde aplicação", "AppServices" },
            {"serviços deaplicação", "AppServices" },
            {"serviçosdeaplicação", "AppServices" },
            {"serviço de aplicação", "AppServices" },
            {"serviçode aplicação", "AppServices" },
            {"serviço deaplicação", "AppServices" },
            {"serviçodeaplicação", "AppServices" },
            {"servicosde aplicação", "AppServices" },
            {"servicos deaplicação", "AppServices" },
            {"servicosdeaplicação", "AppServices" },
            {"servico de aplicação", "AppServices" },
            {"servicode aplicação", "AppServices" },
            {"servico deaplicação", "AppServices" },
            {"servicodeaplicação", "AppServices" },
            {"app services", "AppServices" },
            {"app service", "AppServices" },
            {"appservices", "AppServices" },
            {"site", "WebApp" },
            {"sites", "WebApp" },
            {"web app", "WebApp" },
            {"web apps", "WebApp" },
            {"webapp", "WebApp" },
            {"webapps", "WebApp" },
            {"aplicação web", "WebApp" },
            {"aplicaçãoweb", "WebApp" },
            {"aplicaçao web", "WebApp" },
            {"aplicaçaoweb", "WebApp" },
            {"aplicacão web", "WebApp" },
            {"aplicacãoweb", "WebApp" },
            {"aplicacao web", "WebApp" },
            {"aplicacaoweb", "WebApp" },
            {"mobile", "MobileApp" },
            {"mobileapp", "MobileApp" },
            {"mobile app", "MobileApp" },
            {"aplicativo móvel", "MobileApp" },
            {"aplicativo movel", "MobileApp" },
            {"aplicativomovel", "MobileApp" },
            {"aplicativomóvel", "MobileApp" },
            {"dispositivo móvel", "MobileApp" },
            {"dispositivomóvel", "MobileApp" },
            {"dispositivomovel", "MobileApp" },
            {"dispositivo movel", "MobileApp" },
            {"celular", "MobileApp" },
            {"cellphone", "MobileApp" },
            {"aplicativos móveis", "MobileApp" },
            {"aplicativos moveis", "MobileApp" },
            {"aplicativosmoveis", "MobileApp" },
            {"aplicativosmóveis", "MobileApp" },
            {"dispositivos móveis", "MobileApp" },
            {"dispositivos moveis", "MobileApp" },
            {"dispositivossmoveis", "MobileApp" },
            {"dispositivossmóveis", "MobileApp" },
            {"logic apps", "LogicApps" },
            {"logicapps", "LogicApps" },
            {"logic app", "LogicApps" },
            {"logicapp", "LogicApps" },
            {"aplicativos lógicos", "LogicApps" },
            {"aplicativoslógicos", "LogicApps" },
            {"aplicativos logicos", "LogicApps" },
            {"aplicativoslogicos", "LogicApps" },
            {"aplicativo lógico", "LogicApps" },
            {"aplicativológico", "LogicApps" },
            {"aplicativo logico", "LogicApps" },
            {"aplicativologico", "LogicApps" },
            {"apiapp", "APIApps" },
            {"apiapps", "APIApps" },
            {"api app", "APIApps" },
            {"api apps", "APIApps" },
            {"notification", "Notification Hub" },
            {"notificationhub", "Notification Hub" },
            {"notification hub", "Notification Hub" },
            {"notifications", "Notification Hub" },
            {"notificacao", "Notification Hub" },
            {"notificaçao", "Notification Hub" },
            {"notificacão", "Notification Hub" },
            {"notificação", "Notification Hub" },
            {"notificações", "Notification Hub" },
            {"notificaçoes", "Notification Hub" },
            {"notificacões", "Notification Hub" },
            {"notificacoes", "Notification Hub" },
            {"gerenciamento de API", "API Management" },
            {"gerenciamento API", "API Management" },
            {"gestão de API", "API Management" },
            {"gestao de API", "API Management" },
            {"api management", "API Management" },
            {"apimanagement", "API Management" },
            {"functions", "Azure Functions" },
            {"function", "Azure Functions" },
            {"função", "Azure Functions" },
            {"funcão", "Azure Functions" },
            {"funcao", "Azure Functions" },
            {"funçao", "Azure Functions" },
            {"sql azure", "SQL Azure" },
            {"sqlazure", "SQL Azure" },
            {"sql paas", "SQL Azure" },
            {"storage", "Storage" },
            {"armazenamento", "Storage" },
            {"table", "Storage" },
            {"queue", "Storage" },
            {"blob", "Storage" },
            {"arquivo de dados", "Storage" },
            {"tabelas", "Storage" },
            {"files", "Storage" },
            {"iot hub", "IoT Hub" },
            {"iothub", "IoT Hub" },
            {"internetdas coisas", "IoT Hub" },
            {"internet dascoisas", "IoT Hub" },
            {"internetdascoisas", "IoT Hub" },
            {"internet das coisa", "IoT Hub" },
            {"internet of things", "IoT Hub" },
            {"internetof things", "IoT Hub" },
            {"internet ofthings", "IoT Hub" },
            {"internetofthings", "IoT Hub" }
        };
    }
}