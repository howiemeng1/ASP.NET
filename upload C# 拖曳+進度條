<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPLOAD_TEST1.aspx.cs" Inherits="UPLOAD.UPLOAD_TEST1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet"/>
    <style type="text/css">
        .upload-block
         { 
             width: 300px; 
             height:200px; 
             border-style: dotted; 
             border-color: #999999;        
             text-align:center;
             padding: 20px;
             margin: 20px; 
        } 
        .dragover 
        { 
            border-color:#FF9900; 
        } 
        .progress 
        { 
            text-align:center;
            width: 100%; 
        } 
    </style>
    <script>
        function drop_file(e) {
            e.preventDefault();
            var upload_image = document.getElementById('drop_block');
            var elProgress = document.getElementById('upload_progress');
            var images_container = document.getElementById('images_container');
            var objXhr = new XMLHttpRequest();
            var files = e.dataTransfer.files;
            var objForm = new FormData();
            var sucess_count = 0;

            objXhr.upload.onprogress = function (e) {
                if (e.lengthComputable) {
                    var intComplete = (e.loaded / e.total) * 100 | 0;

                    elProgress.innerHTML = intComplete + '%';
                    elProgress.style.width = intComplete + '%';

                    elProgress.setAttribute('aria-valuenow', intComplete);
                }
            }

            objXhr.onload = function (e) {
                upload_image.className = upload_image.className.replace(' dragover', '');
                elProgress.className = elProgress.className.replace(' active', '');

                alert(objXhr.responseText); //接收網頁回傳結果
            }

            objXhr.open('POST', 'UPLOAD_TEST1.aspx');  //接收網頁回傳結果的網頁
            for (var i = 0; i < files.length; i++) {
                if (!files[i].type.match('text.*|image.*|application.*|video.*')) {
                    var name = files[i].name;
                    alert(name + '格式不正確，須為文檔！');
                    continue;
                }

                //文檔（不僅是 pdf，odt 也有這種類型）：input.files[0].type==='application/pdf'
                //音檔 ：input.files[0].type.match('audio.*')
                //影片 ：input.files[0].type.match('video.*')


                objForm.append('images[]', files[i]);
                objForm.append('save_file', "Y");
            }

            objXhr.send(objForm);
        }
</script>
    <script>
        function drag_handler(e) {
            var upload_image = document.getElementById('drop_block');
            var elProgress = document.getElementById('upload_progress');
            e.preventDefault();  //防止瀏覽器執行預設動作
            if (!upload_image.className.match('dragover')) {
                upload_image.className = upload_image.className + ' dragover';
            }

            if (upload_progress.style.width != '0%') {
                upload_progress.style.width = '0%';
            }
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="drop_block" ondragover="javascript: drag_handler(event);" ondrop="javascript: drop_file(event);" class="upload-block">
            請將檔案拖曳到此...
            <div class="progress">
                <div id="upload_progress" class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="" aria-valuemin="0" aria-valuemax="100">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
