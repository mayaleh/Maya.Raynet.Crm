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
            Nahr�n� souboru do ulo�i�t� v CRM. Obsah souboru je pot�eba nahr�t ve form�tu �multipart/form-data� (standardn� form�t pro odesl�n� formul��ov�ch dat obsahuj�c�ch soubor http requestem) a to pod atributem s n�zvem �file�. API vrac� informace o nov� nahran�m souboru (zejm�na unik�tn� identifik�tr souboru - UUID). V�stupn� parametry pak slou�� jako vstup pro API k zalo�en� nov� p��lohy (viz n�e).
        Headers
            X-Instance-Name: instanceName
            Content-Type: multipart/form-data
        Body
            Bin�rn� obsah formul��ov�ch dat, soubor mus� b�t ulo�en pod atributem 'name' = 'file'
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
