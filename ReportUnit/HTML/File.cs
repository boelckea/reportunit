﻿namespace ReportUnit.HTML
{
    internal class File
    {
        /// <summary>
        /// Main source written to the test-suite level report
        /// Fixture and Test blocks are written for each instance from the XML file
        /// Topbar is added to the source only when the Folder level report is created
        /// </summary>
        public static string Base
        {
            get
            {
                return
                    @"<!DOCTYPE html>
                    <html lang='en'>
                        <!--
                            ReportUnit [TestSuite Summary] v1.1 | http://reportunit.relevantcodes.com/
                            Created by Anshoo Arora (Relevant Codes) | Released under the MIT license
                        --> 
                        <head>
                            <meta charset='utf-8'>
                            <meta http-equiv='X-UA-Compatible' content='IE=edge'>
                            <meta name='viewport' content='width=device-width, initial-scale=1'>
                            <meta name='description' content=''>
                            <meta name='author' content=''>
                            <title>ReportUnit TestRunner Report</title>
                            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/css/materialize.min.css'>
                            <link href='http://fonts.googleapis.com/css?family=Nunito:300' rel='stylesheet' type='text/css'>
                            <style>
                                html { 
                                    background-color: #f1f4f8;  
                                }
                                body {
                                    font-family: 'Nunito';
                                    font-size: 14px;
                                    font-weight: 300;
                                }
                                pre {
                                    background-color: #f8f9fa;
                                    border: 1px solid #ddd;
                                    border-radius: 4px;
                                    color: #444;
                                    font-family: Consolas, monospace;
                                    font-size: 13px !important;
                                    padding: 10px;
                                    white-space: pre-wrap;
                                    white-space: -moz-pre-wrap;
                                    white-space: -pre-wrap;    
                                    white-space: -o-pre-wrap;  
                                    word-wrap: break-word;     
                                }
                                th {
                                    font-weight: 400;
                                }
                                td:first-child {
                                    max-width: 400px;
                                    min-width: 150px;
                                    padding-right: 25px;
                                    vertical-align: top;
                                }
                                td {
                                    padding: 8px;
                                    word-break: break-all;
                                }
                                .test-features {
                                    display: none !important;
                                }

                                /* ---- [ global ] ---- */
                                .card-head {
                                    padding-bottom: 20px;
                                }
                                .card-panel {
                                    box-shadow: 0 1px 1px 0 rgba(0, 0, 0, 0.16), 0 1px 4px 0 rgba(0, 0, 0, 0.12);
                                    padding: 15px;
                                }
                                .btn {
                                    font-size: 12px;
                                }
                                .btn i {
                                    font-size: 13px;
                                }
                                .input-field label {
                                    color: #db7093;
                                }
                                .hidden {
                                    display: none;
                                }
                                .select-wrapper input.select-dropdown {
	                                font-size: 14px;
                                }

                                /* ---- [ sidenav / topnav ] ---- */
                                nav, nav .nav-wrapper i, nav a.button-collapse, nav a.button-collapse i {
                                    height: 54px;
                                    line-height: 54px;
                                }
                                .side-nav.fixed {
									width: 280px;
								}
                                .side-nav a {
                                    line-height: 22px;
                                    height: auto;
                                }
                                .side-nav.fixed a {
                                    font-size: 14px;
                                    height: auto;
                                    padding: 15px;
                                }
                                .side-nav a {
                                    height: auto;
                                    padding: 20px 15px;
                                }
                                nav a.button-collapse {
                                    display: inline-block;
                                }
                                .logo {
                                    border-bottom: 1px solid #ddd;
                                    margin-left: -4px;
                                }
                                .logo:hover, .logo a:hover {
                                    background-color: transparent !important;
                                }
                                .logo span {
                                    border: 1px solid #222;
                                    font-size: 14px;
                                    padding: 2px 7px;
                                }
                                .logo-single {
                                    display: none;
                                }
                                .nav-main {
                                    padding-left: 315px;
                                }
                                .page-title .logo {
                                    display: none;
                                }
                                .console-logs-icon, .run-info-icon {
                                    float: right;
                                    font-size: 20px;
                                }
                                .run-info-icon {
                                    padding-right: 55px
                                }
                                .console-logs-icon {
                                    padding-right: 5px;
                                }
            
                                /* ---- [ main ] ---- */
                                .main {
                                    background-color: #f1f4f8;
                                }
                                .main-wrap {
                                    padding: 40px 40px 100px 300px;
                                }
                                .main-wrap > .row {
                                    margin-bottom: 0;
                                }
            
                                /* ---- [ dashboard ] ---- */
                                .card-panel > div {
                                    font-size: 14px;
                                }
                                .dashboard .card-panel {
	                                height: 235px;
                                }
                                .dashboard .card-panel > div {
	                                font-family: Nunito;
	                                font-size: 13px;
	                                font-weight: 300;
                                }
                                .chart-o {
                                    text-align: center;
                                }
                                .chart-o > div {
                                    display: inline-block;
                                }
                                .panel-lead {
                                    font-size: 24px !important;
                                    padding: 50px 0 70px;
                                    text-align: center;
                                }
                
                                /* ---- [ filters ] ---- */
                                .filters {
                                    padding-left: 10px;
                                    padding-top: 50px;
                                }
                                .toggle-type {
                                    float: right;
                                    margin-right: 20px;
                                    margin-top: 35px;
                                }
                                .btn, .btn-large {
                                    background-color: #ee6e73;
                                }
                                .dropdown-content li > a, .dropdown-content li > span {
                                    font-size: 14px;
                                    padding: 7px 20px;
                                }
                
                                /* ---- [ fixture / suites ] ---- */
                                .fixtures .card-panel {
                                    cursor: pointer;
                                    padding-bottom: 8px;
                                }
                                .fixture-head { 
                                    padding-bottom: 60px;
                                    word-break: break-all;                 
                                }
                                .fixture-status-message {
                                    background-color: #f7f8fa;
                                }
                                .fixture-name {
                                    float: left; 
                                    font-size: 20px;
                                    max-width: 410px; 
                                    word-break: break-all; 
                                }
                                .fixture-footer { 
                                    padding: 10px 0; 
                                }
                                .fixture-result {
                                    border-radius: 0.25em;
                                    color: #fff !important;
                                    float: right;
                                    font-size: 11px !important; 
                                    margin-top: 3px;
                                    padding: 2px 7px 1px; 
                                    text-transform: uppercase !important; 
                                }
                                p.description {
                                    border: 1px solid #ddd;
                                    color: #444;
                                    font-size: 14px;
                                    padding: 10px;
                                }
                                .startedAt, .endedAt { 
                                    font-size: 13px; 
                                }
                                .startedAt i, .endedAt i { 
                                    font-size: 13px; 
                                    padding-right: 5px; 
                                }
                                .startedAt i { 
                                    color: #5cb85c; 
                                }
                                .endedAt i { 
                                    color: #d9534f; 
                                    padding-left: 10px;
                                }
                                .fixture-result.fail, .fixture-result.failed, .fixture-result.failure {
                                    background-color: #eb4549;
                                }
                                .fixture-result.pass, .fixture-result.success, .fixture-result.passed {
                                    background-color: #32cd32;
                                }
                                .fixture-result.error { 
                                    background-color: tomato; 
                                }
                                .fixture-result.warning, .fixture-result.bad, .fixture-result.inconclusive { 
                                    background-color: orange; 
                                }                    
                                .fixture-result.skipped, .fixture-result.not-run, .fixture-result.notrun { 
                                    background-color: #1e90ff; 
                                }
                                .fixture-content { 
                                    cursor: auto !important;
                                    display: none; 
                                    padding-bottom: 20px; 
                                }
                                .fixture-content .card {
                                    box-shadow: none;
                                    font-size: 13px;
                                    margin-left: -15px;
                                    margin-right: -15px;
                                }
                                .fixture-content .card .card-content {
                                    padding: 10px 20px;
                                }
                                .is-expanded { 
                                    border: 1px solid #9d9d9d;
                                    color: #000; 
                                    height: auto; 
                                }
                                .failed, .failure, .passed, .success, .warning, .bad, .inconclusive, .skipped, .ignored, .invalid, .error, .not-run, .notrun { 
                                    text-transform: capitalize; 
                                }
                                .failed, .failure { 
                                    color: red; 
                                }
                                .error { 
                                    color: tomato; 
                                }
                                .passed, .success { 
                                    color: #5cb85c; 
                                } 
                                .warning, .bad, .inconclusive, .error { 
                                    color: #f0ad4e; 
                                } 
                                .skipped, .not-run, .notrun, .ignored { 
                                    color: #1e90ff; 
                                }

                                /* ---- [ single ] ---- */
                                .single .page-title .logo {
                                    display: inline-block;
                                }
                                .single .page-title span {
									border-color: #fff;
								}
                                .single #slide-out, .single .button-collapse, .single .mdi-file-folder-open {
                                    display: none !important;
                                }
                                .single .main {
                                    padding-left: 0 !important;
                                }
                                .single .main-wrap {
                                    margin: 0 auto;
                                    padding-left: 40px;
                                    padding-right: 40px;
                                }
                                .single .nav-main {
                                    margin: 0 auto;
                                    padding-left: 52px;
                                }
                                .single .logo-single {
                                    display: inline-block !important;
                                }
                                .single .reportunit-logo-main {
                                    float: left;
                                    margin-right: 0;
                                    padding: 0;
                                }

                                /* ---- [ media queries ] ---- */
                                @media (max-width: 1600px) {
                                    .main-wrap .col.s4 {
                                        padding-right: 0;
                                    }
                                }
                                @media (max-width: 992px) {
                                    .main {
                                        padding-left: 0;
                                    }
                                    .nav-main {
	                                    padding-left: 100px;
                                    }
                                    .single .nav-main {
	                                    padding-left: 100px;
                                    }
                                    .main-wrap {
	                                    padding-left: 40px;
                                    }
                                    .button-collapse {
                                        padding-left: 10px;
                                    }
                                    .single .main-wrap {
                                        width: 95%;
                                    }
                                    .filters .toggle-type {
                                        display: none;
                                    }
                                    .filters .col.s3 {
                                        width: 40%;
                                    }
                                }
                                @media (min-width: 992px) and (max-width: 1300px) {
                                    /* fix for pie charts going out of bounds */
                                    .main-wrap .row:first-child .col.s12 {
                                        width: 33.33% !important;
                                    }
                                    .filters .toggle-type {
                                        display: none;
                                    }
                                }
                            </style>
                            <!--%OPTIONALCSS%-->
                        </head>
                        <body>    
                            <div class='header'>
                                <nav>
                                    <ul id='slide-out' class='side-nav fixed'>
                                        <li class='logo'><a href='http://reportunit.relevantcodes.com/'><span>ReportUnit</span></a></li>
                                        <!--%NAV%-->
                                    </ul>
                                    <a href='#' data-activates='slide-out' class='button-collapse'><i class='mdi-navigation-menu'></i></a>
                                    <div class='nav-main'>
                                        <div class='page-title'>
                                           <div class='logo'><a href='http://reportunit.relevantcodes.com/'><span>ReportUnit</span></a></div>
                                            <span><i class='mdi-file-folder-open'></i>&nbsp;&nbsp;<!--%FILENAME%--></span>
                                            <a class='modal-trigger waves-effect waves-light run-info-icon tooltipped' data-position='left' data-tooltip='Run Info' href='#modal1'><i class='mdi-action-info-outline'></i></a>
                                            <a class='modal-trigger waves-effect waves-light console-logs-icon tooltipped' data-position='left' data-tooltip='Console Logs' href='#modal2'><i class='mdi-action-assignment'></i></a>
                                        </div>
                                    </div>
                                </nav>
                            </div>
                            <div class='main'>
                                <div class='main-wrap'>
                                    <!--%NOTESTSMESSAGE%-->
                                    <div class='row dashboard'>
                                        <div class='col s12 m6 l4'>
                                            <div class='card-panel'>
                                                <div alt='Count of all passed tests' title='Count of all passed tests'>Fixture Summary</div>    
                                                <div class='chart-o' id='suites-dashboard'></div>
                                            </div>
                                        </div>
                                        <div class='col s12 m6 l4'>
                                            <div class='card-panel'>
                                                <div alt='Count of all failed tests' title='Count of all failed tests'>Tests Summary</div>
                                                <div class='chart-o' id='tests-dashboard'></div>
                                            </div>
                                        </div>
                                        <div class='col s12 m12 l4'>
                                            <div class='card-panel'>
                                                <div alt='Count of all inconclusive tests' title='Count of all inconclusive tests'>Pass Percentage</div>
												<div class='panel-lead pass-percentage'></div>
                                                <div class='progress'>
													 <div class='determinate'></div>
												 </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='row'>
                                        <div class='filters'>
                                            <div class='input-field col l3 m4 s12 suite-toggle'>
                                                <select>
                                                    <option value='0' selected>Choose your option</option>
                                                    <option value='1'>Passed</option>
                                                    <option value='2'>Failed</option>
                                                    <option value='3'>Error</option>
                                                    <option value='4'>Inconclusive</option>
                                                    <option value='5'>Skipped</option>
                                                    <option value='6'>Clear Filters</option>
                                                </select>
                                                <label>Filter Suites</label>
                                            </div>
                                            <div class='input-field col l3 m4 s12 tests-toggle'>
                                                <select>
                                                    <option value='0' selected>Choose your option</option>
                                                    <option value='1'>Passed</option>
                                                    <option value='2'>Failed</option>
                                                    <option value='3'>Error</option>
                                                    <option value='4'>Inconclusive</option>
                                                    <option value='5'>Skipped</option>
                                                    <option value='6'>Clear Filters</option>
                                                </select>
                                                <label>Filter Tests</label>
                                            </div>
                                            <div class='input-field col l3 m4 s12 feature-toggle'>
                                                <select>
                                                    <option value='0' selected>Choose your option</option>
                                                    <!--%CATEGORYLIST%-->
                                                    <option value='x'>Clear Filters</option>
                                                </select>
                                                <label>Filter Features</label>
                                            </div>
                                            <div class='switch toggle-type'>
                                                <label>
                                                    Accordion
                                                    <input type='checkbox'>
                                                    <span class='lever'></span>
                                                    Toggle
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='row'>
                                        <div class='fixtures'>
                                            <!--%INSERTFIXTURE%-->
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div id='modal1' class='modal'>
                                <div class='modal-content'>
                                    <h4><!--%FILENAME%--> RunInfo</h4>
                                    <table class='bordered'>
                                        <tr><th>Param</th><th>Value</th></tr>
                                        <!--%RUNINFO%-->
                                    </table>
                                </div>
                                <div class='modal-footer'>
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn-flat'>Close</a>
                                </div>
                                <div class='hidden total-tests'><!--%TOTALTESTS%--></div>
                                <div class='hidden total-passed'><!--%PASSED%--></div>
                                <div class='hidden total-failed'><!--%FAILED%--></div>
                                <div class='hidden total-inconclusive'><!--%INCONCLUSIVE%--></div>
                                <div class='hidden total-errors'><!--%ERRORS%--></div>
                                <div class='hidden total-skipped'><!--%SKIPPED%--></div>
                            </div>
                            <div id='modal2' class='modal'>
                                <div class='modal-content'>
                                    <h4>Console Log</h4>
                                    <!--%CONSOLELOGS%-->
                                </div>
                                <div class='modal-footer'>
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn-flat'>Close</a>
                                </div>
                            </div>
                        </body>
                        <script src='https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js'></script>
                        <script src='http://cdnjs.cloudflare.com/ajax/libs/masonry/3.2.2/masonry.pkgd.min.js' type='text/javascript' charset='utf-8'></script>
                        <script type='text/javascript' src='https://www.google.com/jsapi'></script>
                        <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/js/materialize.min.js'></script>
                        <script type='text/javascript'>
                            google.load('visualization', '1', {packages:['corechart']});
                            $(document).ready(function() {
                                $('select').material_select();
                                $('.modal-trigger').leanModal();
                                $('.tooltipped').tooltip({delay: 20});
                                $('.button-collapse').sideNav({ menuWidth: 280 });
                                $('.fixture-content .card-content').each(function() {
                                    if ($(this).text().trim() == '') {
                                        $(this).hide(); 
                                    }
                                });
                                resetFilters();
                                var total = parseInt($('.total-tests').text());
                                var passed = parseInt($('.total-passed').text());
                                var failed = parseInt($('.total-failed').text());
                                var inconclusive = parseInt($('.total-inconclusive').text());
                                var errors = parseInt($('.total-errors').text());
                                var skipped = parseInt($('.total-skipped').text());
                                $('.nav.nav-sidebar a').filter(function(){
                                    return this.href.match(/[^\/]+$/)[0] == document.location.pathname.match(/[^\/]+$/)[0];
                                }).parent().addClass('active');
                                var $container = $('.fixtures').masonry({
                                    percentPosition: true
                                });
                                $(document).ready(sizing);
                                $(window).resize(sizing);
                                function sizing() {
	                                if ($(window).width() > 1650) {
		                                $('.fixtures .s4').css('width', '50%');
	                                } else if ($(window).width() < 1120) {
		                                $('.fixtures .s4').css('width', '99%');
	                                } else {
		                                $('.fixtures .s4').css('width', '49%');
	                                }
	                                $('.fixtures').masonry();
                                }
                                $container.on( 'click', '.card-panel', function(evt) {
                                    var cls = evt.target.className;
                                    cls = evt.target.nodeName.toLowerCase();
                                    if (cls.indexOf('div') >= 0 || cls.indexOf('span') >= 0) {
                                        var elm = $(this);
                                        var content = elm.find('.fixture-content');
                                        cls = '';
                                        if (content.is(':visible')) {
                                            elm.removeClass('is-expanded has-pre');
                                            content.hide(0);
                                        }
                                        else {
                                            if (!$('.toggle-type input').prop('checked'))
                                                $('.fixtures .card-panel').removeClass('is-expanded').find('.fixture-content').hide(0);
                                            if (elm.find('pre').length > 0) cls = 'has-pre';
                                            elm.addClass('is-expanded ' + cls);
                                            content.fadeIn(200);
                                        }
                                        $container.masonry();
                                    }
                                });
                                $('.menu li').click(function(evt) {
                                    var elm = $(this).children('span');
                                    if (elm.hasClass('selected'))
                                        return;
                                    $('#' + $('.menu span.selected').removeClass('selected').attr('class')).hide(0);
                                    $('#' + elm.attr('class')).fadeIn(200); elm.addClass('selected'); 
                                });
                                $('.suite-toggle li').click(function() {
                                    var opt = $(this).text().toLowerCase();
                                    if (opt != 'choose your option') {
                                        if (opt == 'clear filters') {
                                            resetFilters();
                                        } else {
                                            $('.fixtures .card-panel').hide(0);
                                            $('.fixture-result.' + opt).closest('.card-panel').show(0);
                                        }
                                        $('.fixtures').masonry();
                                    }                                
                                });
                                $('.tests-toggle li').click(function() {
                                    var opt = $(this).text().toLowerCase();
                                    if (opt != 'choose your option') {
                                        if (opt == 'clear filters') {
                                            resetFilters();
                                        } else {
                                            if ($('tr.has-filter').length > 0) 
                                                resetFilters();
                                            $('.fixture-content td:nth-child(2)').not('.' + opt).parent().addClass('has-filter').hide(0);
                                            hideEmptyPanels();
                                        }
                                        $('.fixtures').masonry();
                                    }
                                });
                                $('.feature-toggle li').click(function() {
                                    var opt = $(this).text();
                                    if (opt.toLowerCase() != 'choose your option') {
                                        if (opt.toLowerCase() == 'clear filters') {
                                            resetFilters();
                                        }  
                                        else {
                                            filterByCategory(opt);
                                        }
                                    }
                                    $('.fixtures').masonry();
                                });
                                if (document.location.href.indexOf('?') > -1) {
                                    var evt = window.location.search.split('?')[1];
                                    switch (evt.toLowerCase()) {
                                        case 'passedtests': clickListItem('tests-toggle', 1); break;
                                        case 'failedtests': clickListItem('tests-toggle', 2); break;
                                        case 'errortests': clickListItem('tests-toggle', 3); break;
                                        case 'inconclusivetests': clickListItem('tests-toggle', 4); break;
                                        case 'skippedtests': clickListItem('tests-toggle', 5); break;
                                        case 'passedsuites': clickListItem('suite-toggle', 1); break;
                                        case 'failedsuites': clickListItem('suite-toggle', 2); break;
                                        case 'errorsuites': clickListItem('suite-toggle', 3); break;
                                        case 'inconclusivesuites': clickListItem('suite-toggle', 4); break;
                                        case 'skippedsuites': clickListItem('suite-toggle', 5); break;
                                        default: break;
                                    }
                                }
                                function filterByCategory(cat) {
                                    resetFilters();
                                    $('.fixture-content .card-panel').show(0);
                                    $('td.test-features').each(function() {
                                        if (!($(this).hasClass(cat))) {
                                            $(this).closest('tr').addClass('has-filter').hide(0);
                                        }
                                    });
                                    hideEmptyPanels();
                                    $('.fixtures').masonry();
                                }
                                function hideEmptyPanels() {
                                    $('.fixture-content').filter(function() {
                                        return ($(this).find('tr.has-filter').length == $(this).find('tr').length - 1);
                                    }).closest('.card-panel').hide(0);
                                }
                                function resetFilters() {
                                    $('.fixtures .card-panel').show(0);
                                    $('tr').removeClass('has-filter').show();
                                    $('.suite-toggle li:first-child, .tests-toggle li:first-child, .feature-toggle li:first-child').click();
                                }
                                function clickListItem(listClass, index) {
                                    $('.' + listClass).find('li').get(index).click();
                                }
                                var passedPercentage = Math.round(((passed / total) * 100)) + '%';
								$('.pass-percentage').text(passedPercentage);
								$('.dashboard .determinate').attr('style', 'width:' + passedPercentage);
                                google.setOnLoadCallback(suitesChart);
								google.setOnLoadCallback(testsChart);
								function suitesChart() {
									var data = google.visualization.arrayToDataTable([
									  ['Test Status', 'Count'],
									  ['Pass', $('.fixture-result.passed').length],
									  ['Fail', $('.fixture-result.failed').length],
									  ['Inconclusive', $('.fixture-result.inconclusive').length],
									  ['Error', $('.fixture-result.error').length],
									  ['Skipped', $('.fixture-result.skipped').length]
									]);
									var options = {
									  backgroundColor: { fill:'transparent' },
									  chartArea: {'width': '92%', 'height': '100%'},
									  colors: ['#00af00', 'red', 'orange', 'tomato', 'dodgerblue'],
									  fontName: 'Nunito',
									  fontSize: '11',
									  titleTextStyle: { color: '#1366d7', fontSize: '14' },
									  pieHole: 0.55,
									  height: 180,
									  pieSliceText: 'value', 
									  width: 200
									};
									var chart = new google.visualization.PieChart(document.getElementById('suites-dashboard'));
									chart.draw(data, options);
								  }
								function testsChart() {
									var data = google.visualization.arrayToDataTable([
									  ['Test Status', 'Count'],
									  ['Pass', passed],
									  ['Fail', failed],
									  ['Inconclusive', inconclusive],
									  ['Error', errors],
									  ['Skipped', skipped]
									]);
									var options = {
									  backgroundColor: { fill:'transparent' },
									  chartArea: {'width': '92%', 'height': '100%'},
									  colors: ['#00af00', 'red', 'orange', 'tomato', 'dodgerblue'],
									  fontName: 'Nunito',
									  fontSize: '11',
									  titleTextStyle: { color: '#1366d7', fontSize: '14' },
									  pieHole: 0.55,
									  height: 180,
									  pieSliceText: 'value', 
									  width: 200
									};
									var chart = new google.visualization.PieChart(document.getElementById('tests-dashboard'));
									chart.draw(data, options);
								  }
                            });
                        </script>
                    </html>";
            }
        }

        /// <summary>
        /// Fixture block
        /// Box in which all tests will be created
        /// It is masonry style and can be used as a toggle or accordion (default)
        /// </summary>
        public static string Fixture
        {
            get
            {
                return @"<div class='col s4'>
                            <div class='card-panel'>
                                <div class='fixture-head'>
                                    <span class='fixture-name'><!--%FIXTURENAME%--></span>
                                    <span class='fixture-result <!--%FIXTURERESULT%-->'><!--%FIXTURERESULT%--></span>
                                </div>
                                <div class='fixture-content'>
                                    <div class='card fixture-status-message'>
                                        <div class='card-content'>
                                            <!--%FIXTURESTATUSMSG%-->
                                        </div>
                                    </div>
                                    <table class='bordered'>
                                        <tr>
                                            <th>TestName</th>
                                            <th>Status</th>
                                        </tr>
                                        <!--%INSERTTEST%-->
                                    </table>
                                </div>
                                <div <!--%FOOTERDISPLAY%--> class='fixture-footer'>
                                    <span <!--%FIXTURESTARTEDATDISPLAY%--> alt='Fixture started at time' title='Fixture started at time' class='startedAt'><i class='mdi-device-access-time'></i><!--%FIXTURESTARTEDAT%--></span>
                                    <span <!--%FIXTUREENDEDATDISPLAY%--> alt='Fixture ended at time' title='Fixture ended at time' class='endedAt'><i class='mdi-device-access-time'></i><!--%FIXTUREENDEDAT%--></span>
                                </div>
                            </div>
                        </div>
                        <!--%INSERTFIXTURE%-->";
            }
        }

        /// <summary>
        /// Test block
        /// Each test is added as a row inside the Fixture container
        /// </summary>
        public static string Test
        {
            get
            {
                return @"<tr>
                            <td class='test-name'><!--%TESTNAME%--></td>
                            <td class='<!--%TESTSTATUS%-->'><!--%TESTSTATUS%--><!--%TESTSTATUSMSG%--></td>
                            <td class='test-features <!--%TESTFEATURE%-->'></td>
                        </tr>
                        <!--%INSERTTEST%-->";
            }
        }

        public static string RunInfoRow
        {
            get
            {
                return @"<tr>
                            <td><!--%RUNINFOPARAM%--></td><td><!--%RUNINFOVALUE%--></td>
                        </tr>";
            }
        }

        private static int cat = 1;

        public static string CategoryLi
        {
            get
            {
                return "<option value='" + cat++ + "'><!--%CATEGORYNAME%--></option>";
            }
        }

        /// <summary>
        /// Message to display when there are no tests in the TestResult.xml file
        /// </summary>
        public static string NoTestsMessage
        {
            get
            {
                return @"<div class='no-tests-available'>
                            <div role='alert' class='alert alert-danger'>
                                <strong>No tests!</strong>  There were no tests found for <!--%INXML%-->.
                            </div>
                        </div>";
            }
        }

        public static string NoTestsCSS
        {
            get
            {
                return @"<style>.row { display: none !important; }</style>";
            }
        }
    }
}
