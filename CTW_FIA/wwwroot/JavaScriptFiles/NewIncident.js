<script type="text/javascript">
    var vpage_name ="";
    var vparam_x ="";
    var vpage_status = "";
    var FirString="";
    var ProvinceList= [];
    $(document).ready(function () {
        const urlParams = new URLSearchParams(window.location.search);
    const param_x = urlParams.get('id');
    const page_status = urlParams.get('pageStatus');
    const page_name= urlParams.get('pageName');
    vpage_name=page_name;
    vparam_x=param_x;
    $('#asgstr').val(vparam_x);
    vpage_status=page_status;

    LoadIncidentProvince();
    LoadReportingAgency();
    //  var FirString = $('#FirString').val(); 
    $('#FirString').html("");
    if(page_status == "u" && param_x != "" && page_name == "PreviewIncidentRecord")
    {

        ViewIncidentById(param_x);
            }
    else
    {

    }
    });

    $("#FirNo").keyup(function(){

        $('#FirString').html("");
    FirString="";
    FirString = "FIR#" + $('#FirNo').val();
    FirString = FirString +"/"+ $('#RegYear').val()+" ";
    FirString = FirString +"U/S:"+ $('#US').val()+" ";
    FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,";
    FirString = FirString +"District:"+ $('#IncidentDistrictList').val()+" ";
    $('#FirString').html(FirString); 
  });
    $("#RegYear").keyup(function(){

        $('#FirString').html("");
    //  FirString="";
    //  FirString = $('#FirNo').val(); 
    //FirString = FirString + $('#RegYear').val(); 
    //FirString = FirString + $('#US').val(); 
    FirString="";
    //var ps= $('#IncidentPoliceStation').val();
    //var d=$('#IncidentDistrictList').val();
    FirString = "FIR#" + $('#FirNo').val();
    FirString = FirString +"/"+ $('#RegYear').val()+" ";
    FirString = FirString +"U/S:"+ $('#US').val()+" ";
    FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,";

    FirString = FirString +"District:"+ $('#IncidentDistrictList').val()+" ";
    $('#FirString').html(FirString);
        //$('#FirString').html(FirString); 
  });
    $("#US").keyup(function(){

        //$('#FirString').html(""); 
        //       FirString="";
        //  FirString = $('#FirNo').val(); 
        //FirString = FirString + $('#RegYear').val(); 
        //FirString = FirString + $('#US').val(); 

        //  $('#FirString').html(FirString); 
        FirString = "";
    FirString = "FIR#" + $('#FirNo').val();
    FirString = FirString +"/"+ $('#RegYear').val()+" ";
    FirString = FirString +"U/S:"+ $('#US').val()+" ";
    FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,";
    FirString = FirString +"District:"+ $('#IncidentDistrictList').val()+" ";
    $('#FirString').html(FirString); 
  });

    function selectdistrict()
    {
        // alert("d");
        FirString = "";
    FirString = "FIR#" + $('#FirNo').val();
    FirString = FirString +"/"+ $('#RegYear').val()+" ";
    FirString = FirString +"U/S:"+ $('#US').val()+" ";
    FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,";
    FirString = FirString +"District:"+ $('#IncidentDistrictList').val()+" ";
    $('#FirString').html(FirString); 
  }
    function selectPolice()
    {
        // alert("p");
        FirString = "";
    FirString = "FIR#" + $('#FirNo').val();
    FirString = FirString +"/"+ $('#RegYear').val()+" ";
    FirString = FirString +"U/S:"+ $('#US').val()+" ";
    FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,";
    FirString = FirString +"District:"+ $('#SelectDistrict').val()+" ";
    $('#FirString').html(FirString); 
  }
  //  $("#IncidentDistrictList").onChange(function(){
        // alert("d");
        //       FirString="";
        //        FirString = "FIR#" + $('#FirNo').val(); 
        //      FirString = FirString +"/"+ $('#RegYear').val()+" "; 
        //      FirString = FirString +"U/S:"+ $('#US').val()+" "; 
        //      FirString = FirString +"P.S:"+ $('#PoliceStation').val()+" ,"; 
        //      FirString = FirString +"District:"+ $('#IncidentDistrictList').val()+" "; 
        //      $('#FirString').html(FirString); 
        //});
        function IncidentClick() {
            if (vpage_status == "u" && vparam_x != "" && vpage_name == "PreviewIncidentRecord") {
                IncidentUpdation();

            }
            else {
                IncidentInsertion();
            }

        }

    //$("#incident_form").validate({
    //    rules: {
    //        OperationName: "required"
    //    },
    //    messages: {
    //        OperationName: "Please Fill Subject Name"
    //    },
    //    submitHandler: function (form) {
    //        // your ajax would go here.

    //        alert("Form Submit Successfully");
    //        IncidentInsertion();
    //        return false; // extra insurance preventing the default form action
    //    }
    //});

    function IncidentInsertion() {
            var FirNo = "";
            var RegYear = 0;
            var US = "";
            var OperationName = "";
            var IncidentCountryList = "Pakistan";
            var IncidentCity = "";
            var IncidentProvinceList = "";
            var IncidentDistrictList = "";
            var IncidentPostalZip = "";
            var IncidentPoliceStation = "";
            var numberKilled = "";
            var numberInjured = "";
            var InjuredName = "";
            var KilledNames = "";
            var Target = "";
            var Motive = "";
            var weapon = "";
            var Recoveries = "";
            var CrimeSceneRecoveries = "";
            var caseStatus = "";
            var CTWRemarks = "";
            var NumberArrested = "";
            var PreIncidentThread = "";
            var Reportedby = "";
            var CTWRemarks = "";
            var IncidentLatitude = "";
            var IncidentLongitude = "";

            FirNo = $('#FirNo').val();
            //  alert(FirNo);
            RegYear = $('#RegYear').val();
            US = $('#US').val();
            OperationName = $('#OperationName').val();
            IncidentCountryList = "Pakistan";
            IncidentCity = $('#IncidentCity').val();
            IncidentProvinceList = $('#IncidentProvinceList').val();
            IncidentDistrictList = $('#IncidentDistrictList').val();
            IncidentPostalZip = $('#IncidentPostalZip').val();
            IncidentPoliceStation = $('#PoliceStation').val();
            IncidentAddress = $('#IncidentAddress').val();
            numberKilled = $('#NumberKilled').val();
            numberInjured = $('#NumberInjured').val();
            InjuredName = $('#InjuredName').val();
            KilledNames = $('#KilledNames').val();
            Target = $('#IncidentTarget').val();
            Motive = $('#Motive').val();
            weapon = $('#Weapon').val();
            Recoveries = $('#Recoveries').val();
            crimeSceneRecoveries = $('#CrimeSceneRecoveries').val();
            caseStatus = $('#CaseStatus').val();
            CaseProgress = $('#CaseProgress').val();
            NumberArrested = $('#NumberArrested').val();
            PreIncidentThread = $('#PreIncidentThread').val();
            Reportedby = $('#Reportedby').val();
            CTWRemarks = $('#IncidentmemRemarks').val();

            IncidentLatitude = $('#IncidentLatitude').val();
            IncidentLongitude = $('#IncidentLongitude').val();

            var settings = {
                "url": "/api/Incidents",
                "method": "POST",
                "timeout": 0,
                "headers": {
                    "Content-Type": "application/json"
                },
                "data": JSON.stringify({
                    "intID": 0,
                    "strURN": "stri12",
                    "strOperationName": OperationName,
                    "firNo": FirNo,
                    "regYear": RegYear,
                    "US": US,
                    "country": IncidentCountryList,
                    "province": IncidentProvinceList,
                    "city": IncidentCity,
                    "district": IncidentDistrictList,
                    "postalZip": IncidentPostalZip,
                    "policeStation": IncidentPoliceStation,
                    "address": IncidentAddress,
                    //"incidentDate": IncidentDate,
                    //"incidentTime": IncidentTime,
                    //"incidentTimeEnd": IncidentTimeEnd,
                    "incidentDate": "2022-04-01T07:13:36.415Z",
                    "incidentTime": "2022-04-01T07:13:36.415Z",
                    "incidentTimeEnd": "2022-04-01T07:13:36.415Z",
                    "dateSent": "2022-04-01T07:13:36.415Z",
                    "latitude": IncidentLongitude,
                    "longitude": IncidentLatitude,
                    "NumberKilled": numberKilled,
                    "NumberInjured": numberInjured,
                    "InjuredName": InjuredName,
                    "CasualtiesNames": KilledNames,
                    "Weapon": weapon,
                    "Target": Target,
                    "Motive": Motive,
                    "Recoveries": Recoveries,
                    "PreIncidentThread": PreIncidentThread,
                    "CrimeSceneRecoveries": crimeSceneRecoveries,
                    "CaseStatus": caseStatus,
                    "NumberArrested": NumberArrested,
                    "Reportedby": Reportedby,
                    "strCaseProgress": CaseProgress,
                    "CTWRemarks": CTWRemarks,
                    "createdBy": "admin",
                    "UpdatedBy": "admin",
                    "IsDeleted": false
                }),
            };
            $.ajax(settings).done(function (response) {
                console.log(response);
                alert("Incident has been added Successfully");

                if (confirm('Do you want to add Media File ?')) {

                    console.log("Media File.");
                    localStorage.setItem("strURN", response.strURN);
                    localStorage.setItem("tableName", "Incident");
                    window.location.href = "/Admin/Records/AddMedia";
                }
                else {

                    //var id=response.strURN;
                    localStorage.setItem("strURN", response.strURN);
                    localStorage.setItem("tableName", "Incident");
                    //   window.location.href = "/Admin/Records/AddMedia";
                    var id = response.strURN;
                    // window.location.href = "/Admin/Records/PreviewIncidentRecord?id="+id;
                    window.location.href = "/Admin/Records/PreviewRecord?controller=Incidents&id=" + id;

                }
            });
        }
  

      function IncidentUpdation()
    {
       var stdId=vparam_x;
    var FirNo = "";
    var RegYear=0;
    var US="";
    var OperationName = "";
    var IncidentCountryList ="Pakistan";
    var IncidentCity="";
    var IncidentProvinceList="";
    var IncidentDistrictList="";
    var IncidentPostalZip="";
    var IncidentPoliceStation="";
    var numberKilled="";
    var numberInjured ="";
    var InjuredName="";
    var KilledNames ="";
    var Target="";
    var Motive ="";
    var weapon="";
    var Recoveries ="";
    var CrimeSceneRecoveries ="";
    var caseStatus ="";
    var CTWRemarks ="";
    var NumberArrested ="";
    var PreIncidentThread ="";
    var Reportedby ="";
    var IncidentLatitude ="";
    var IncidentLongitude ="";

    FirNo = $('#FirNo').val();
    //  alert(FirNo);
    RegYear = $('#RegYear').val();
    US = $('#US').val();
    OperationName = $('#OperationName').val();
    IncidentCountryList = "Pakistan";
    IncidentCity = $('#IncidentCity').val();
    IncidentProvinceList = $('#IncidentProvinceList').val();
    IncidentDistrictList = $('#IncidentDistrictList').val();
    IncidentPostalZip = $('#IncidentPostalZip').val();
    IncidentPoliceStation = $('#PoliceStation').val();
    IncidentAddress = $('#IncidentAddress').val();
    numberKilled = $('#NumberKilled').val();
    numberInjured = $('#NumberInjured').val();
    InjuredName = $('#InjuredName').val();
    KilledNames = $('#KilledNames').val();
    Target = $('#IncidentTarget').val();
    Motive = $('#Motive').val();
    weapon = $('#Weapon').val();
    Recoveries = $('#Recoveries').val();
    crimeSceneRecoveries = $('#CrimeSceneRecoveries').val();
    caseStatus = $('#CaseStatus').val();
    CaseProgress = $('#CaseProgress').val();
    NumberArrested = $('#NumberArrested').val();
    PreIncidentThread = $('#PreIncidentThread').val();
    Reportedby = $('#Reportedby').val();
    CTWRemarks = $('#IncidentmemRemarks').val();
    IncidentLatitude = $('#IncidentLatitude').val();
    IncidentLongitude = $('#IncidentLongitude').val();

    var settings = {
        "url": "/api/Incidents/"+stdId,
    "method": "Put",
    "timeout": 0,
    "headers": {
        "Content-Type": "application/json"
                  },
    "data": JSON.stringify({
        "intID": 0,
    "strURN": stdId,
    "strOperationName": OperationName,
    "firNo": FirNo,
    "regYear": RegYear,
    "US": US,
    "country": IncidentCountryList,
    "province": IncidentProvinceList,
    "city": IncidentCity,
    "district": IncidentDistrictList,
    "postalZip": IncidentPostalZip,
    "policeStation": IncidentPoliceStation,
    "address": IncidentAddress,
    //"incidentDate": IncidentDate,
    //"incidentTime": IncidentTime,
    //"incidentTimeEnd": IncidentTimeEnd,
    "incidentDate": "2022-04-01T07:13:36.415Z",
    "incidentTime": "2022-04-01T07:13:36.415Z",
    "incidentTimeEnd": "2022-04-01T07:13:36.415Z",
    "latitude": IncidentLatitude,
    "longitude": IncidentLongitude,
    "NumberKilled":numberKilled,
    "NumberInjured": numberInjured,
    "InjuredName": InjuredName,
    "CasualtiesNames": KilledNames,
    "Weapon": weapon,
    "Target": Target,
    "Motive": Motive,
    "Recoveries": Recoveries,
    "CrimeSceneRecoveries": crimeSceneRecoveries,
    "CaseStatus": caseStatus,
    "NumberArrested": NumberArrested,
    "Reportedby": Reportedby,
    "strCaseProgress": CaseProgress,
    "CTWRemarks": CTWRemarks,
    "createdBy": "admin",
    "UpdatedBy": "admin",
    "IsDeleted":false
              }), 
            };
    $.ajax(settings).done(function (response) {
        console.log(response);
    alert("Incident has been updated Successfully");

    var id=response.strURN;
    localStorage.setItem("strURN", response.strURN);
    localStorage.setItem("tableName", "Incident");
    window.location.href = "/Admin/Records/PreviewRecord?controller=Incidents&id="+id;

              // window.location.href = "/Admin/Records/PreviewIncidentRecord?id="+stdId;
              });
         }

    function LoadReportingAgency()
    {
      var ReportingAgencyList = $('#Reportedby');

    try {
        $.ajax({
            url: '/api/ReportingAgencies',
            method: 'Get',
            //headers: {
            //  'Content-Type': 'application/x-www-form-urlencoded'
            //},
            dataType: 'json',

            success: function (data) {
                $('#Reportedby').empty();
                var v = JSON.stringify(data);
                var selIncAgency = "";
                selIncAgency += "<option value='' disabled selected>--Select--</option>";
                $.each(data, function (k, v) {
                    var id1 = data[k].reportingAgencyTitle;
                    // var val1 =  JSON.stringify(data[k].ReportingAgencyTitle);
                    selIncAgency += "<option value='" + id1 + "'>" + id1 + "</option>";
                });
                ReportingAgencyList.append(selIncAgency);

            },
            error: function (request, status, error) {

                //   alert("Error.");
            }
        });
    }
    catch (err) {
        exceptionHandeld(err)
    }
    }
    function LoadIncidentCountry()
    {
      var IncidentCountries = $('#IncidentCountryList');


    try {
        $.ajax({
            url: '/api/Countries',
            method: 'Get',
            //headers: {
            //  'Content-Type': 'application/x-www-form-urlencoded'
            //},
            dataType: 'json',

            success: function (data) {

                var v = JSON.stringify(data);
                var selOpts = "";
                selOpts += "<option value='' disabled selected>--Select--</option>";
                $.each(data, function (k, v) {
                    var id = data[k].strCountry;
                    var val = data[k].strCountry;
                    selOpts += "<option value='" + id + "'>" + val + "</option>";
                });
                IncidentCountries.append(selOpts);


            },
            error: function (request, status, error) {

                alert("Error.");
            }
        });
    }
    catch (err) {
        exceptionHandeld(err)
    }
    }
    function LoadIncidentProvince()
    {
        var IncidentProvinces = $('#IncidentProvinceList');

    try {
        $.ajax({
            url: '/api/ProvinceLists',
            method: 'Get',
            //headers: {
            //  'Content-Type': 'application/x-www-form-urlencoded'
            //},
            dataType: 'json',
            beforeSend: function () {

                //$("#loader").show();
            },
            complete: function () {

                //$("#loader").hide();
            },
            success: function (data) {
                ProvinceList = data;
                $('#IncidentProvinceList').empty();
                console.log(ProvinceList);
                var v = JSON.stringify(data);
                //   alert(JSON.stringify(data));
                var selOptsProvince = "";
                selOptsProvince += "<option value='' disabled selected>--Select--</option>";
                $.each(data, function (k, v) {
                    var id = data[k].strProvince;
                    var val = data[k].strProvince;
                    selOptsProvince += "<option value='" + id + "'>" + val + "</option>";
                });
                IncidentProvinces.append(selOptsProvince);
            },
            error: function (request, status, error) {

                //  alert("Error.");
            }
        });
    }
    catch (err) {
        exceptionHandeld(err)
    }
    }

    function LoadDistrict()
    {
        
         var IncidentProv = $('#IncidentProvinceList').val();
    var IncidentDistrictList = $('#IncidentDistrictList');
    try {
        $.ajax({
            url: '/api/DistrictList/SearchDis?pro=' + IncidentProv,
            method: 'Post',
            dataType: 'json',
            success: function (data) {
                $('#IncidentDistrictList').empty();
                var v = JSON.stringify(data);
                var selOptsDis = "";
                selOptsDis += "<option value='' disabled selected>--Select--</option>";
                $.each(data, function (k, v) {
                    var id = data[k].strDistrict;
                    var val = data[k].strDistrict;
                    selOptsDis += "<option value='" + id + "'>" + val + "</option>";
                });
                IncidentDistrictList.append(selOptsDis);
            },
            error: function (request, status, error) {
                // alert("Error.");
            }
        });
        }
    catch (err) {
        exceptionHandeld(err)
    }
  
    }



    $("#selectedcountry").change(function () {
         //alert("sadasd");
       var conceptName = $('#selectedcountry').find(":selected").text();
    LoadCountryProvince(conceptName);
    });
    $("#personprovince").change(function () {
        var pn = $('#personprovince').find(":selected").text();
    getDistrictlist(pn);
    });
    function LoadCountryProvince(country)
    {

        $("#personprovince option").remove();
    $("#SelectDistrict option").remove();
    var personprovince = $('#personprovince');
    $.ajax({
        url: '/AllRcord/getProvinceList'
    , type: 'GET'
    , data: {country:country}
    , contentType: 'application/json'
    , success: function (response) {
         
                 var Prlist = "";
    Prlist="<option>Select Province</option>";
    for (var m = 0; m < response.length; m++) {
        Prlist += "<option value='" + response[m] + "'>" + response[m] + "</option>";
                    
                }
    personprovince.append(Prlist);
         
        }
    });
    }
    function LoadPolice()
    {
             var pn = $('#SelectDistrict').find(":selected").text();
    var Pl=  policeStationlis=$('#PoliceStation');
    $.ajax({
        url: '/AllRcord/getPoliceStation'
    , type: 'GET'
    , data: {District:pn}
    , contentType: 'application/json'
    , success: function (response) {
         
                 var Dslist = "";
    Dslist=null;

    for (var d = 0; d < response.length; d++) {
        Dslist += "<option value='" + response[d] + "'>" + response[d] + "</option>";
                    
                }
    Pl.append(Dslist);
         
        }
    });
        }
    function getDistrictlist(Province)
    {

        $("#SelectDistrict option").remove();

    var Districlist = $('#SelectDistrict');
    $.ajax({
        url: '/AllRcord/getDistrictlist'
    , type: 'GET'
    , data: {Province:Province}
    , contentType: 'application/json'
    , success: function (response) {
         
                 var Dslist = "<option>Select District</option>";


    for (var d = 0; d < response.length; d++) {
        Dslist += "<option value='" + response[d] + "'>" + response[d] + "</option>";
                    
                }
    Districlist.append(Dslist);
         
        }
    });
    }

    // function LoadDistrict()
    //{
    //     var IncidentProvinces = $('#IncidentProvinceList').val();
    //     var IncidentDistrictList = $('#IncidentDistrictList');


    //         var selOptsDes = "";
    //         selOptsDes += "<option value='' disabled selected>--Select--</option>";
    //           var jsonObject = $.parseJSON(ProvinceList);
    //            $.each(jsonObject, function (i, propVal) {

    //                var dbdisTable  = dbList.filter(function(v) {
    //                return v.strProvince == IncidentProvinces; // Filter out the appropriate one
    //                })[0].strDistrict;

    //               IncidentDistrictList.append(dbdisTable);
    //         },
    //        error: function (request, status, error) {

    //            alert("Error.");
    //        }
    //    });
    //}
    //catch (err) {
    //    exceptionHandeld(err)
    //}
    //}
     </script>