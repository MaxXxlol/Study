function isCompatible(){if(navigator.appVersion.indexOf('MSIE')!==-1&&parseFloat(navigator.appVersion.split('MSIE')[1])<6){return false;}return true;}var startUp=function(){mw.config=new mw.Map(true);mw.loader.addSource({"local":{"loadScript":"//bits.wikimedia.org/ru.wikipedia.org/load.php","apiScript":"/w/api.php"}});mw.loader.register([["site","1344001013",[],"site"],["noscript","1317998450",[],"noscript"],["startup","1346744392",[],"startup"],["filepage","1293840000"],["user.groups","1293840000",[],"user"],["user","1293840000",[],"user"],["user.cssprefs","1346744392",["mediawiki.user"],"private"],["user.options","1346744392",[],"private"],["user.tokens","1293840000",[],"private"],["mediawiki.language.data","1346744376",["mediawiki.language.init"]],["skins.chick","1345471724"],["skins.cologneblue","1345471724"],["skins.modern","1345471724"],["skins.monobook","1345471724"],["skins.nostalgia","1345471724"],["skins.simple","1345471724"],["skins.standard","1345471724"],["skins.vector",
"1345471724"],["jquery","1346679372"],["jquery.appear","1345471724"],["jquery.arrowSteps","1345471724"],["jquery.async","1345471724"],["jquery.autoEllipsis","1345471724",["jquery.highlightText"]],["jquery.badge","1345471724"],["jquery.byteLength","1345471724"],["jquery.byteLimit","1345471724",["jquery.byteLength"]],["jquery.checkboxShiftClick","1345471724"],["jquery.client","1345471724"],["jquery.collapsibleTabs","1345471724"],["jquery.color","1345471724",["jquery.colorUtil"]],["jquery.colorUtil","1345471724"],["jquery.cookie","1345471724"],["jquery.delayedBind","1345471724"],["jquery.expandableField","1345471724",["jquery.delayedBind"]],["jquery.farbtastic","1345471724",["jquery.colorUtil"]],["jquery.footHovzer","1345471724"],["jquery.form","1345471724"],["jquery.getAttrs","1345471724"],["jquery.highlightText","1345471724"],["jquery.hoverIntent","1345471724"],["jquery.json","1345471724"],["jquery.localize","1345471724"],["jquery.makeCollapsible","1346726376"],["jquery.messageBox",
"1345471724"],["jquery.mockjax","1345471724"],["jquery.mw-jump","1345471724"],["jquery.mwExtension","1345471724"],["jquery.placeholder","1345471724"],["jquery.qunit","1345471724"],["jquery.qunit.completenessTest","1345471724",["jquery.qunit"]],["jquery.spinner","1345471724"],["jquery.suggestions","1345471724",["jquery.autoEllipsis"]],["jquery.tabIndex","1345471724"],["jquery.tablesorter","1346726379"],["jquery.textSelection","1345471724",["jquery.client"]],["jquery.validate","1345471724"],["jquery.xmldom","1345471724"],["jquery.tipsy","1345471723"],["jquery.ui.core","1346274564",["jquery"],"jquery.ui"],["jquery.ui.widget","1346274564",[],"jquery.ui"],["jquery.ui.mouse","1346274564",["jquery.ui.widget"],"jquery.ui"],["jquery.ui.position","1346274564",[],"jquery.ui"],["jquery.ui.draggable","1346274564",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.droppable","1346274564",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget","jquery.ui.draggable"],
"jquery.ui"],["jquery.ui.resizable","1346274564",["jquery.ui.core","jquery.ui.widget","jquery.ui.mouse"],"jquery.ui"],["jquery.ui.selectable","1346274564",["jquery.ui.core","jquery.ui.widget","jquery.ui.mouse"],"jquery.ui"],["jquery.ui.sortable","1346274564",["jquery.ui.core","jquery.ui.widget","jquery.ui.mouse"],"jquery.ui"],["jquery.ui.accordion","1346274564",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.autocomplete","1346274564",["jquery.ui.core","jquery.ui.widget","jquery.ui.position"],"jquery.ui"],["jquery.ui.button","1346274564",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.datepicker","1346274564",["jquery.ui.core"],"jquery.ui"],["jquery.ui.dialog","1346274564",["jquery.ui.core","jquery.ui.widget","jquery.ui.button","jquery.ui.draggable","jquery.ui.mouse","jquery.ui.position","jquery.ui.resizable"],"jquery.ui"],["jquery.ui.progressbar","1346274564",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.slider","1346274564",[
"jquery.ui.core","jquery.ui.widget","jquery.ui.mouse"],"jquery.ui"],["jquery.ui.tabs","1346274564",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.effects.core","1346274564",["jquery"],"jquery.ui"],["jquery.effects.blind","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.bounce","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.clip","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.drop","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.explode","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.fade","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.fold","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.highlight","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.pulsate","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.scale","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.shake","1346274564",[
"jquery.effects.core"],"jquery.ui"],["jquery.effects.slide","1346274564",["jquery.effects.core"],"jquery.ui"],["jquery.effects.transfer","1346274564",["jquery.effects.core"],"jquery.ui"],["mediawiki","1345471724"],["mediawiki.api","1345471724",["mediawiki.util"]],["mediawiki.api.category","1345471724",["mediawiki.api","mediawiki.Title"]],["mediawiki.api.edit","1345471724",["mediawiki.api","mediawiki.Title"]],["mediawiki.api.parse","1345471724",["mediawiki.api"]],["mediawiki.api.titleblacklist","1345471724",["mediawiki.api","mediawiki.Title"]],["mediawiki.api.watch","1345471724",["mediawiki.api","user.tokens"]],["mediawiki.debug","1345471724",["jquery.footHovzer"]],["mediawiki.debug.init","1345471724",["mediawiki.debug"]],["mediawiki.feedback","1345471724",["mediawiki.api.edit","mediawiki.Title","mediawiki.jqueryMsg","jquery.ui.dialog"]],["mediawiki.htmlform","1345471724"],["mediawiki.Title","1345471724",["mediawiki.util"]],["mediawiki.Uri","1345471724"],["mediawiki.user","1345471724",[
"jquery.cookie","mediawiki.api"]],["mediawiki.util","1346726376",["jquery.client","jquery.cookie","jquery.messageBox","jquery.mwExtension"]],["mediawiki.action.edit","1345471724",["jquery.textSelection","jquery.byteLimit"]],["mediawiki.action.history","1345471724",[],"mediawiki.action.history"],["mediawiki.action.history.diff","1345471724",[],"mediawiki.action.history"],["mediawiki.action.view.dblClickEdit","1345471724",["mediawiki.util"]],["mediawiki.action.view.metadata","1346726377"],["mediawiki.action.view.rightClickEdit","1345471724"],["mediawiki.action.watch.ajax","1293840000",["mediawiki.page.watch.ajax"]],["mediawiki.language","1345471724",["mediawiki.language.data"]],["mediawiki.language.init","1345471724"],["mediawiki.jqueryMsg","1345471724",["mediawiki.util","mediawiki.language"]],["mediawiki.libs.jpegmeta","1345471724"],["mediawiki.page.ready","1345471724",["jquery.checkboxShiftClick","jquery.makeCollapsible","jquery.placeholder","jquery.mw-jump","mediawiki.util"]],[
"mediawiki.page.startup","1345471724",["jquery.client","mediawiki.util"]],["mediawiki.page.watch.ajax","1346726376",["mediawiki.page.startup","mediawiki.api.watch","mediawiki.util"]],["mediawiki.special","1345471724"],["mediawiki.special.block","1345471724",["mediawiki.util"]],["mediawiki.special.changeemail","1346741980",["mediawiki.util"]],["mediawiki.special.changeslist","1345471724",["jquery.makeCollapsible"]],["mediawiki.special.movePage","1345471724",["jquery.byteLimit"]],["mediawiki.special.preferences","1345471724"],["mediawiki.special.recentchanges","1345471724",["mediawiki.special"]],["mediawiki.special.search","1346726378"],["mediawiki.special.undelete","1345471724"],["mediawiki.special.upload","1346726542",["mediawiki.libs.jpegmeta","mediawiki.util"]],["mediawiki.special.javaScriptTest","1345471724",["jquery.qunit"]],["mediawiki.tests.qunit.testrunner","1345471724",["jquery.qunit","jquery.qunit.completenessTest","mediawiki.page.startup","mediawiki.page.ready"]],[
"mediawiki.legacy.ajax","1345471724",["mediawiki.util","mediawiki.legacy.wikibits"]],["mediawiki.legacy.commonPrint","1345471724"],["mediawiki.legacy.config","1345471724",["mediawiki.legacy.wikibits"]],["mediawiki.legacy.IEFixes","1345471724",["mediawiki.legacy.wikibits"]],["mediawiki.legacy.mwsuggest","1346726376",["mediawiki.legacy.wikibits"]],["mediawiki.legacy.preview","1345471724",["mediawiki.legacy.wikibits"]],["mediawiki.legacy.protect","1345471724",["mediawiki.legacy.wikibits","jquery.byteLimit"]],["mediawiki.legacy.shared","1345471724"],["mediawiki.legacy.oldshared","1345471724"],["mediawiki.legacy.upload","1345471724",["mediawiki.legacy.wikibits","mediawiki.util"]],["mediawiki.legacy.wikibits","1345471724",["mediawiki.util"]],["mediawiki.legacy.wikiprintable","1345471724"],["ext.gadget.collapserefs","1330486281",["mediawiki.util"]],["ext.gadget.directLinkToCommons","1343413132",["mediawiki.util"]],["ext.gadget.referenceTooltips","1345937840"],["ext.gadget.preview",
"1337817318",["mediawiki.util"]],["ext.gadget.urldecoder","1343169427",["mediawiki.util","mediawiki.legacy.wikibits"]],["ext.gadget.addThisArticles","1343862372"],["ext.gadget.markadmins","1346596117",["mediawiki.util"]],["ext.gadget.disableUpdatedMarker","1342642202"],["ext.gadget.OldDiff","1335402832"],["ext.gadget.HideFlaggedRevs","1297722991"],["ext.gadget.roundCorners","1293840000"],["ext.gadget.dropdown-menus","1297188992"],["ext.gadget.ajaxQuickDelete","1317568270"],["mobile.device.default","1345471885"],["mobile.device.webkit","1345471885"],["mobile.device.android","1345471885"],["mobile.device.iphone","1345471885"],["mobile.device.iphone2","1345471885"],["mobile.device.palm_pre","1345471885"],["mobile.device.kindle","1345471885"],["mobile.device.blackberry","1345471885"],["mobile.device.simple","1345471885"],["mobile.device.psp","1345471885"],["mobile.device.wii","1345471885"],["mobile.device.operamini","1345471885"],["mobile.device.operamobile","1345471885"],[
"mobile.device.nokia","1345471885"],["ext.wikihiero","1345472052"],["ext.wikihiero.Special","1345472052",["jquery.spinner"]],["ext.cite","1345471781",["jquery.tooltip"]],["jquery.tooltip","1345471781"],["ext.specialcite","1345471781"],["ext.geshi.local","1293840000"],["ext.flaggedRevs.basic","1345471844"],["ext.flaggedRevs.advanced","1346726376",["mediawiki.util"]],["ext.flaggedRevs.review","1346726376",["mediawiki.util"]],["ext.categoryTree","1346726378"],["ext.categoryTree.css","1345471760"],["ext.nuke","1345471893"],["ext.centralauth","1346742030"],["ext.centralauth.noflash","1345471771"],["ext.centralNotice.interface","1345471775"],["ext.centralNotice.bannerStats","1345471775"],["ext.centralNotice.bannerController","1345471775"],["ext.collection.jquery.jstorage","1345471794",["jquery.json"]],["ext.collection.suggest","1345471794",["ext.collection.bookcreator"]],["ext.collection","1345471794",["ext.collection.bookcreator","jquery.ui.sortable"]],["ext.collection.bookcreator",
"1345471794",["ext.collection.jquery.jstorage"]],["ext.collection.checkLoadFromLocalStorage","1345471794",["ext.collection.jquery.jstorage"]],["ext.abuseFilter","1345471735"],["ext.abuseFilter.edit","1345471735",["jquery.textSelection","jquery.spinner"]],["ext.abuseFilter.tools","1345471735",["jquery.spinner"]],["ext.abuseFilter.examine","1345471735"],["ext.vector.collapsibleNav","1346726431",["mediawiki.util","jquery.client","jquery.cookie","jquery.tabIndex"],"ext.vector"],["ext.vector.collapsibleTabs","1345471984",["jquery.collapsibleTabs","jquery.delayedBind"],"ext.vector"],["ext.vector.editWarning","1346726431",[],"ext.vector"],["ext.vector.expandableSearch","1345471984",["jquery.client","jquery.expandableField","jquery.delayedBind"],"ext.vector"],["ext.vector.footerCleanup","1345471984",["mediawiki.jqueryMsg"],"ext.vector"],["ext.vector.sectionEditLinks","1345471984",["jquery.cookie","jquery.clickTracking"],"ext.vector"],["ext.vector.simpleSearch","1346726431",[
"jquery.autoEllipsis","jquery.client","jquery.placeholder","jquery.suggestions","mediawiki.legacy.mwsuggest"],"ext.vector"],["contentCollector","1345472022",[],"ext.wikiEditor"],["jquery.wikiEditor","1346726486",["jquery.client","jquery.textSelection","jquery.delayedBind"],"ext.wikiEditor"],["jquery.wikiEditor.iframe","1345472022",["jquery.wikiEditor","contentCollector"],"ext.wikiEditor"],["jquery.wikiEditor.dialogs","1345472022",["jquery.wikiEditor","jquery.wikiEditor.toolbar","jquery.ui.dialog","jquery.ui.button","jquery.ui.draggable","jquery.ui.resizable","jquery.tabIndex"],"ext.wikiEditor"],["jquery.wikiEditor.dialogs.config","1346726486",["jquery.wikiEditor","jquery.wikiEditor.dialogs","jquery.wikiEditor.toolbar.i18n","jquery.suggestions","mediawiki.Title"],"ext.wikiEditor"],["jquery.wikiEditor.highlight","1345472022",["jquery.wikiEditor","jquery.wikiEditor.iframe"],"ext.wikiEditor"],["jquery.wikiEditor.preview","1345472022",["jquery.wikiEditor"],"ext.wikiEditor"],[
"jquery.wikiEditor.previewDialog","1345472022",["jquery.wikiEditor","jquery.wikiEditor.dialogs"],"ext.wikiEditor"],["jquery.wikiEditor.publish","1345472022",["jquery.wikiEditor","jquery.wikiEditor.dialogs"],"ext.wikiEditor"],["jquery.wikiEditor.templateEditor","1345472022",["jquery.wikiEditor","jquery.wikiEditor.iframe","jquery.wikiEditor.dialogs"],"ext.wikiEditor"],["jquery.wikiEditor.templates","1345472022",["jquery.wikiEditor","jquery.wikiEditor.iframe"],"ext.wikiEditor"],["jquery.wikiEditor.toc","1345472022",["jquery.wikiEditor","jquery.wikiEditor.iframe","jquery.ui.draggable","jquery.ui.resizable","jquery.autoEllipsis","jquery.color"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar","1345472022",["jquery.wikiEditor","jquery.wikiEditor.toolbar.i18n"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar.config","1345472022",["jquery.wikiEditor","jquery.wikiEditor.toolbar.i18n","jquery.wikiEditor.toolbar","jquery.cookie","jquery.async"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar.i18n",
"1293840000",[],"ext.wikiEditor"],["ext.wikiEditor","1345472022",["jquery.wikiEditor"],"ext.wikiEditor"],["ext.wikiEditor.dialogs","1345472022",["ext.wikiEditor","ext.wikiEditor.toolbar","jquery.wikiEditor.dialogs","jquery.wikiEditor.dialogs.config"],"ext.wikiEditor"],["ext.wikiEditor.highlight","1345472022",["ext.wikiEditor","jquery.wikiEditor.highlight"],"ext.wikiEditor"],["ext.wikiEditor.preview","1345472022",["ext.wikiEditor","jquery.wikiEditor.preview"],"ext.wikiEditor"],["ext.wikiEditor.previewDialog","1345472022",["ext.wikiEditor","jquery.wikiEditor.previewDialog"],"ext.wikiEditor"],["ext.wikiEditor.publish","1345472022",["ext.wikiEditor","jquery.wikiEditor.publish"],"ext.wikiEditor"],["ext.wikiEditor.templateEditor","1345472022",["ext.wikiEditor","ext.wikiEditor.highlight","jquery.wikiEditor.templateEditor"],"ext.wikiEditor"],["ext.wikiEditor.templates","1345472022",["ext.wikiEditor","ext.wikiEditor.highlight","jquery.wikiEditor.templates"],"ext.wikiEditor"],[
"ext.wikiEditor.toc","1345472022",["ext.wikiEditor","ext.wikiEditor.highlight","jquery.wikiEditor.toc"],"ext.wikiEditor"],["ext.wikiEditor.tests.toolbar","1345472022",["ext.wikiEditor.toolbar"],"ext.wikiEditor"],["ext.wikiEditor.toolbar","1345472022",["ext.wikiEditor","jquery.wikiEditor.toolbar","jquery.wikiEditor.toolbar.config"],"ext.wikiEditor"],["ext.wikiEditor.toolbar.hideSig","1345472022",[],"ext.wikiEditor"],["mobile","1345471885"],["mobile.beta","1345471885"],["mobile.filePage","1345471885"],["mobile.references","1345471885"],["ext.math.mathjax","1345471876",[],"ext.math.mathjax"],["ext.math.mathjax.enabler","1345471876"],["ext.babel","1345471758"],["ext.apiSandbox","1346741645",["mediawiki.util","jquery.ui.button"]],["ext.interwiki.specialpage","1345471859",["jquery.makeCollapsible"]],["ext.checkUser","1345471779",["mediawiki.util"]]]);mw.config.set({"wgLoadScript":"//bits.wikimedia.org/ru.wikipedia.org/load.php","debug":false,"skin":"vector","stylepath":
"//bits.wikimedia.org/static-1.20wmf10/skins","wgUrlProtocols":"http\\:\\/\\/|https\\:\\/\\/|ftp\\:\\/\\/|irc\\:\\/\\/|ircs\\:\\/\\/|gopher\\:\\/\\/|telnet\\:\\/\\/|nntp\\:\\/\\/|worldwind\\:\\/\\/|mailto\\:|news\\:|svn\\:\\/\\/|git\\:\\/\\/|mms\\:\\/\\/|\\/\\/","wgArticlePath":"/wiki/$1","wgScriptPath":"/w","wgScriptExtension":".php","wgScript":"/w/index.php","wgVariantArticlePath":false,"wgActionPaths":{},"wgServer":"//ru.wikipedia.org","wgUserLanguage":"ru","wgContentLanguage":"ru","wgVersion":"1.20wmf10","wgEnableAPI":true,"wgEnableWriteAPI":true,"wgMainPageTitle":"Заглавная страница","wgFormattedNamespaces":{"-2":"Медиа","-1":"Служебная","0":"","1":"Обсуждение","2":"Участник","3":"Обсуждение участника","4":"Википедия","5":"Обсуждение Википедии","6":"Файл","7":"Обсуждение файла","8":"MediaWiki","9":"Обсуждение MediaWiki","10":"Шаблон","11":
"Обсуждение шаблона","12":"Справка","13":"Обсуждение справки","14":"Категория","15":"Обсуждение категории","100":"Портал","101":"Обсуждение портала","102":"Инкубатор","103":"Обсуждение Инкубатора","104":"Проект","105":"Обсуждение проекта","106":"Арбитраж","107":"Обсуждение арбитража"},"wgNamespaceIds":{"медиа":-2,"служебная":-1,"":0,"обсуждение":1,"участник":2,"обсуждение_участника":3,"википедия":4,"обсуждение_википедии":5,"файл":6,"обсуждение_файла":7,"mediawiki":8,"обсуждение_mediawiki":9,"шаблон":10,"обсуждение_шаблона":11,"справка":12,"обсуждение_справки":13,"категория":14,"обсуждение_категории":15,"портал":100,
"обсуждение_портала":101,"инкубатор":102,"обсуждение_инкубатора":103,"проект":104,"обсуждение_проекта":105,"арбитраж":106,"обсуждение_арбитража":107,"изображение":6,"обсуждение_изображения":7,"участница":2,"обсуждение_участницы":3,"вп":4,"incubator":102,"incubator_talk":103,"и":102,"про":104,"wikiproject":104,"wikiproject_talk":105,"ак":106,"arbcom":106,"image":6,"image_talk":7,"media":-2,"special":-1,"talk":1,"user":2,"user_talk":3,"project":4,"project_talk":5,"file":6,"file_talk":7,"mediawiki_talk":9,"template":10,"template_talk":11,"help":12,"help_talk":13,"category":14,"category_talk":15},"wgSiteName":"Википедия","wgFileExtensions":["png","gif","jpg","jpeg","xcf","pdf","mid","ogg","ogv","svg","djvu","tiff","tif","oga"],"wgDBname":"ruwiki","wgFileCanRotate":true,"wgAvailableSkins":{"chick":"Chick","cologneblue":
"CologneBlue","modern":"Modern","monobook":"MonoBook","myskin":"MySkin","nostalgia":"Nostalgia","simple":"Simple","standard":"Standard","vector":"Vector"},"wgExtensionAssetsPath":"//bits.wikimedia.org/static-1.20wmf10/extensions","wgCookiePrefix":"ruwiki","wgResourceLoaderMaxQueryLength":-1,"wgCaseSensitiveNamespaces":[],"wgMWSuggestTemplate":"//ru.wikipedia.org/w/api.php?action=opensearch\x26search={searchTerms}\x26namespace={namespaces}\x26suggest","wgCollectionVersion":"1.6.1","wgCollapsibleNavBucketTest":false,"wgCollapsibleNavForceNewVersion":false,"wgWikiEditorToolbarClickTracking":false,"wgWikiEditorMagicWords":{"redirect":"#перенаправление","img_right":"справа","img_left":"слева","img_none":"без","img_center":"центр","img_thumbnail":"мини","img_framed":"обрамить","img_frameless":"безрамки"},"wgNoticeFundraisingUrl":"https://donate.wikimedia.org/wiki/Special:LandingCheck","wgCentralPagePath":"//meta.wikimedia.org/w/index.php"
,"wgNoticeBannerListLoader":"Служебная:BannerListLoader"});};if(isCompatible()){document.write("\x3cscript src=\"//bits.wikimedia.org/ru.wikipedia.org/load.php?debug=false\x26amp;lang=ru\x26amp;modules=jquery%2Cmediawiki\x26amp;only=scripts\x26amp;skin=vector\x26amp;version=20120903T133612Z\" type=\"text/javascript\"\x3e\x3c/script\x3e");}delete isCompatible;;

/* cache key: ruwiki:resourceloader:filter:minify-js:7:cc24fe37fe42c4f93fd202ffeda429c0 */
