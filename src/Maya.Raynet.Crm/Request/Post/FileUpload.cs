// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Post
{
    public class FileUpload : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public FileUpload()
        {
                Actions.Add("fileUpload");
        }
        /*
         
        TODO
            Nahrání souboru do uložištì v CRM. Obsah souboru je potøeba nahrát ve formátu ‘multipart/form-data’ (standardní formát pro odeslání formuláøových dat obsahujících soubor http requestem) a to pod atributem s názvem ‘file’. API vrací informace o novì nahraném souboru (zejména unikátní identifikátr souboru - UUID). Výstupní parametry pak slouží jako vstup pro API k založení nové pøílohy (viz níže).
        Headers
            X-Instance-Name: instanceName
            Content-Type: multipart/form-data
        Body
            Binární obsah formuláøových dat, soubor musí být uložen pod atributem 'name' = 'file'
        Response
            {
              "uuid": "7d694dbb4e6241829de8a385da797283",
              "fileName": "picture.png",
              "contentType": "image/png",
              "fileSize": 24309
            }
        */
        public Task ExecuteAsync(ApiClient apiClient)
            => throw new NotImplementedException();
    }
}
