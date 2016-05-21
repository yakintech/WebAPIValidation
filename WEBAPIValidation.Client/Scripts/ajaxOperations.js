function PolynomAjax(url, data, type) {
    /// <param name="url">data işlemlerinin yapılacağı api uzantısı. Örneğin "/api/getproducts/" </param>
    /// <param name="data">data:Gidecek js objesi (eğer metot post ise)</param>
    /// <param name="type">type:İşlem tipi. String olarak "POST" veya "GET"</param>
    var apiurl = "http://localhost:49852/" + url;
    var result = {};

    $.ajax({
        async: false,
        url: apiurl,
        data: data,
        type: type,
        success: function (e) {
            result = e;
        },
        error: function (m) {
            result = m;
            //eğer apide validation a takılmışsa validation mesaj(lar)ını döndürür
            if (m.status == "400") {
                var msg = "";
                var response = JSON.parse(result.responseText);
                if (response != null) {
                    var modelState = response.ModelState;

                    for (var key in modelState) {
                        if (modelState.hasOwnProperty(key)) {
                            msg += modelState[key] + "\n"
                        }
                    }
                    result = msg;
                }
            }

        }
    })

    return result;
}