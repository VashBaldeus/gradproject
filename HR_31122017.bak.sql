/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.6.38 : Database - hr
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hr` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;

USE `hr`;

/*Table structure for table `archived_reports` */

DROP TABLE IF EXISTS `archived_reports`;

CREATE TABLE `archived_reports` (
  `eid` bigint(20) NOT NULL,
  `id` bigint(9) NOT NULL DEFAULT '0',
  `enter_time` datetime DEFAULT NULL,
  `exit_time` datetime DEFAULT NULL,
  `total_hours` int(2) DEFAULT NULL,
  PRIMARY KEY (`eid`,`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16le;

/*Data for the table `archived_reports` */

/*Table structure for table `city_codes` */

DROP TABLE IF EXISTS `city_codes`;

CREATE TABLE `city_codes` (
  `city` int(11) NOT NULL AUTO_INCREMENT,
  `city_name` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`city`),
  KEY `city` (`city`)
) ENGINE=InnoDB AUTO_INCREMENT=1271 DEFAULT CHARSET=utf16le;

/*Data for the table `city_codes` */

insert  into `city_codes`(`city`,`city_name`) values (1,'אבו גווייעד'),(2,'אבו גוש'),(3,'אבו  סנאן'),(4,'אבו  סריחאן'),(5,'אבו עבדון'),(6,'אבו עמאר'),(7,'אבו עמרה'),(8,'אבו קורינאת'),(9,'אבו קרינאת'),(10,'אבו רובייעה'),(11,'אבו רוקייק'),(12,'אבו תלול'),(13,'אבטין'),(14,'אבטליון'),(15,'אביאל'),(16,'אביבים'),(17,'אביגדור'),(18,'אביחיל'),(19,'אביטל'),(20,'אביעזר'),(21,'אבירים'),(22,'אבני איתן'),(23,'אבן יהודה'),(24,'אבני חפץ'),(25,'אבן מנחם'),(26,'אבן ספיר'),(27,'אבן שמואל'),(28,'אבנת'),(29,'אבשלום'),(30,'אדורה'),(31,'אדירים'),(32,'אדמית'),(33,'אדרת'),(34,'אודים'),(35,'אודם'),(36,'אוהד'),(37,'אום אל-פחם'),(38,'אום אל-קוטוף'),(39,'אום בטין'),(40,'אומן'),(41,'אומץ'),(42,'אופקים'),(43,'אורה'),(44,'אורה גנוז'),(45,'אורה נר'),(46,'אורות'),(47,'אורטל'),(48,'אור יהודה'),(49,'אורים'),(50,'אורנים'),(51,'אורנית'),(52,'אור עקיבא'),(53,'אושה'),(54,'אזור'),(55,'אחווה'),(56,'אחוזם'),(57,'אחוזת ברק'),(58,'אחיהוד'),(59,'אחיטוב'),(60,'אחיסמך'),(61,'אחיעזר'),(62,'אטרש'),(63,'איבים'),(64,'אייל'),(65,'איילת השחר'),(66,'אילון'),(67,'אילות'),(68,'אילניה'),(69,'אילת'),(70,'אירוס'),(71,'איתמר'),(72,'איתן'),(73,'איתנים'),(74,'אכסאל'),(75,'אל-עזי'),(76,'אל-עריאן'),(77,'אל-רום'),(78,'אלומה'),(79,'אלומות'),(80,'אלון הגליל'),(81,'אלוני אבא'),(82,'אלוני הבשן'),(83,'אלוני יצחק'),(84,'אלונים'),(85,'אלון מורה'),(86,'אלון שבות'),(87,'אלי-עד'),(88,'אליאב'),(89,'אליכין'),(90,'אליפז'),(91,'אליפלט'),(92,'אליקים'),(93,'אלישיב'),(94,'אלישמע'),(95,'אלמגור'),(96,'אלמוג'),(97,'אלסייד'),(98,'אלעד'),(99,'אלעזר'),(100,'אלפי מנשה'),(101,'אלקוש'),(102,'אלקנה'),(103,'אמונים'),(104,'אמירים'),(105,'אמנון'),(106,'אמציה'),(107,'אניעם'),(108,'אסד'),(109,'אספר'),(110,'אעבלין'),(111,'אעצם'),(112,'אפיניש'),(113,'אפיק'),(114,'אפיקים'),(115,'אפק'),(116,'אפרת'),(117,'ארבל'),(118,'ארגמן'),(119,'ארז'),(120,'אריאל'),(121,'ארסוף'),(122,'אשבול'),(123,'אשבל'),(124,'אשדוד'),(125,'אשדות יעקב'),(126,'אשחר'),(127,'אשכולות'),(128,'אשלהנשיא'),(129,'אשלים'),(130,'אשקלון'),(131,'אשרת'),(132,'אשתאול'),(133,'אתגר'),(134,'באקהאל-גרביה'),(135,'באראורה'),(136,'בארגנים'),(137,'בארותיים'),(138,'בארותיצחק'),(139,'בארטוביה'),(140,'בארי'),(141,'באריעקב'),(142,'בארמילכה'),(143,'בארשבע'),(144,'בוסתןהגליל'),(145,'בועיינה-נוגידאת'),(146,'בוקעאתא'),(147,'בורגתה'),(148,'בחן'),(149,'בטחה'),(150,'ביצרון'),(151,'ביראל-מכסור'),(152,'בירהדאג'),(153,'ביריה'),(154,'ביתאורן'),(155,'ביתאל'),(156,'ביתאלעזרי'),(157,'ביתאלפא'),(158,'ביתאריה'),(159,'ביתברל'),(160,'ביתגן'),(161,'ביתגוברין'),(162,'ביתגמליאל'),(163,'ביתדגן'),(164,'ביתהגדי'),(165,'ביתהלוי'),(166,'ביתהלל'),(167,'ביתהעמק'),(168,'ביתהערבה'),(169,'ביתהשיטה'),(170,'ביתזיד'),(171,'ביתזית'),(172,'ביתזרע'),(173,'ביתחורון'),(174,'ביתחירות'),(175,'ביתחלקיה'),(176,'ביתחנן'),(177,'ביתחנניה'),(178,'ביתחשמונאי'),(179,'ביתיהושע'),(180,'ביתיוסף'),(181,'ביתינאי'),(182,'ביתיצחק-שערחפר'),(183,'ביתלחםהגלילית'),(184,'ביתמאיר'),(185,'ביתןאהרן'),(186,'ביתנחמיה'),(187,'ביתניר'),(188,'ביתנקופה'),(189,'ביתעובד'),(190,'ביתעוזיאל'),(191,'ביתעזרא'),(192,'ביתעריף'),(193,'ביתצבי'),(194,'ביתקמה'),(195,'ביתקשת'),(196,'ביתרבן'),(197,'ביתרימון'),(198,'ביתרעילית'),(199,'ביתשאן'),(200,'ביתשמש'),(201,'ביתשערים'),(202,'ביתשקמה'),(203,'בלפוריה'),(204,'בןזכאי'),(205,'בניברק'),(206,'בנידקלים'),(207,'בנידרום'),(208,'בנידרור'),(209,'בניה'),(210,'בנייהודה'),(211,'בנימינה-גבעתעדה'),(212,'בנינצרים'),(213,'בניעטרות'),(214,'בניעיש'),(215,'בניציון'),(216,'בניראם'),(217,'בןעמי'),(218,'בןשמן)כפרנוער('),(219,'בןשמן)מושב('),(220,'בסמה'),(221,'בסמתטבעון'),(222,'בענה'),(223,'בצרה'),(224,'בצת'),(225,'בקוע'),(226,'בקעות'),(227,'ברגיורא'),(228,'ברוכין'),(229,'ברורחיל'),(230,'ברוש'),(231,'בריוחאי'),(232,'ברכה'),(233,'ברכיה'),(234,'ברעם'),(235,'ברק'),(236,'ברקאי'),(237,'ברקן'),(238,'ברקת'),(239,'בתהדר'),(240,'בתחן'),(241,'בתחפר'),(242,'בתחצור'),(243,'בתים'),(244,'בתעין'),(245,'בתשלמה'),(246,'גדיידה-מכר'),(247,'גולס'),(248,'גלגוליה'),(249,'גנאביב'),(250,'גסרא-זרקא'),(251,'גש)גושחלב('),(252,'גת'),(253,'גאולים'),(254,'גאוליתימן'),(255,'גאליה'),(256,'גבולות'),(257,'גבים'),(258,'גבע'),(259,'גבעבנימין'),(260,'גבעולים'),(261,'גבעוןהחדשה'),(262,'גבעותבר'),(263,'גבעכרמל'),(264,'גבעתאבני'),(265,'גבעתאלה'),(266,'גבעתברנר'),(267,'גבעתהשלושה'),(268,'גבעתזאב'),(269,'גבעתחן'),(270,'גבעתחיים(איחוד)'),(271,'גבעתחיים(מאוחד)'),(272,'גבעתי'),(273,'גבעתיואב'),(274,'גבעתיים'),(275,'גבעתיערים'),(276,'גבעתישעיהו'),(277,'גבעתכח'),(278,'גבעתנילי'),(279,'גבעתעוז'),(280,'גבעתשמואל'),(281,'גבעתשמש'),(282,'גבעתשפירא'),(283,'גברעם'),(284,'גבת'),(285,'גדות'),(286,'גדיש'),(287,'גדעונה'),(288,'גדרה'),(289,'גונן'),(290,'גורן'),(291,'גורנותהגליל'),(292,'גזית'),(293,'גזר'),(294,'גיאה'),(295,'גיבתון'),(296,'גיזו'),(297,'גילון'),(298,'גילת'),(299,'גינוסר'),(300,'גיניגר'),(301,'גינתון'),(302,'גיתה'),(303,'גיתית'),(304,'גלאון'),(305,'גלגל'),(306,'גלילים'),(307,'גלעד)אבןיצחק('),(308,'גמזו'),(309,'גןהדרום'),(310,'גןהשומרון'),(311,'גנות'),(312,'גנותהדר'),(313,'גןחיים'),(314,'גןיאשיה'),(315,'גןיבנה'),(316,'גניהדר'),(317,'גניטל'),(318,'גנייוחנן'),(319,'גנימודיעין'),(320,'גניעם'),(321,'גניתקווה'),(322,'גןנר'),(323,'גןשורק'),(324,'גןשלמה'),(325,'גןשמואל'),(326,'געש'),(327,'געתון'),(328,'גפן'),(329,'גרופית'),(330,'גשור'),(331,'גשר'),(332,'גשרהזיו'),(333,'גת(קיבוץ)'),(334,'גתרימון'),(335,'דאליתאל-כרמל'),(336,'דבורה'),(337,'דבוריה'),(338,'דבירה'),(339,'דברת'),(340,'דגניהא'),(341,'דגניהב'),(342,'דובב'),(343,'דולב'),(344,'דור'),(345,'דורות'),(346,'דחי'),(347,'דייראל-אסד'),(348,'דיירחנא'),(349,'דיירראפאת'),(350,'דימונה'),(351,'דישון'),(352,'דליה'),(353,'דלתון'),(354,'דמיידה'),(355,'דן'),(356,'דפנה'),(357,'דקל'),(358,'דריגאת'),(359,'האון'),(360,'הבונים'),(361,'הגושרים'),(362,'הדרעם'),(363,'הודהשרון'),(364,'הודיה'),(365,'הודיות'),(366,'הוואשלה'),(367,'הוזייל'),(368,'הושעיה'),(369,'הזורע'),(370,'הזורעים'),(371,'החותרים'),(372,'היוגב'),(373,'הילה'),(374,'המעפיל'),(375,'הסוללים'),(376,'העוגן'),(377,'הראדר'),(378,'הראל'),(379,'הרגילה'),(380,'הרדוף'),(381,'הרעמשא'),(382,'הרצליה'),(383,'הררית'),(384,'ורדון'),(385,'ורדיריחו'),(386,'זבארגה'),(387,'זבדיאל'),(388,'זוהר'),(389,'זיקים'),(390,'זיתן'),(391,'זכרוןיעקב'),(392,'זכריה'),(393,'זמר'),(394,'זמרת'),(395,'זנוח'),(396,'זרועה'),(397,'זרזיר'),(398,'זרחיה'),(399,'חואלד'),(400,'חואלד'),(401,'חבצלת השרון'),(402,'חבר'),(403,'חברון'),(404,'חגור'),(405,'חגי'),(406,'חגלה'),(407,'חד-נס'),(408,'חדיד'),(409,'חדרה'),(410,'חוגייראת(דהרה)'),(411,'חולדה'),(412,'חולון'),(413,'חולית'),(414,'חולתה'),(415,'חוסן'),(416,'חוסנייה'),(417,'חופית'),(418,'חוקוק'),(419,'חורה'),(420,'חורפיש'),(421,'חורשים'),(422,'חזון'),(423,'חיבת ציון'),(424,'חיננית'),(425,'חיפה'),(426,'חירות'),(427,'חלוץ'),(428,'חלמיש'),(429,'חלץ'),(430,'חמאם'),(431,'חמד'),(432,'חמדיה'),(433,'חמדת'),(434,'חמרה'),(435,'חניאל'),(436,'חניתה'),(437,'חנתון'),(438,'חספין'),(439,'חפץחיים'),(440,'חפצי-בה'),(441,'חצב'),(442,'חצבה'),(443,'חצור-אשדוד'),(444,'חצורהגלילית'),(445,'חצרבארותיים'),(446,'חצרותחולדה'),(447,'חצרותיסף'),(448,'חצרותכח'),(449,'חצרים'),(450,'חרבלאת'),(451,'חרוצים'),(452,'חריש'),(453,'חרמש'),(454,'חרשים'),(455,'חשמונאים'),(456,'טבריה'),(457,'טובא-זנגריה'),(458,'טורעאן'),(459,'טייבה'),(460,'טייבה)בעמק('),(461,'טירה'),(462,'טירתיהודה'),(463,'טירתכרמל'),(464,'טירתצבי'),(465,'טל-אל'),(466,'טללים'),(467,'טלמון'),(468,'טלשחר'),(469,'טמרה'),(470,'טמרה)יזרעאל('),(471,'טנא'),(472,'טפחות'),(473,'יאנוח-גת'),(474,'יבול'),(475,'יבנאל'),(476,'יבנה'),(477,'יגור'),(478,'יגל'),(479,'ידבנימין'),(480,'ידהשמונה'),(481,'ידחנה'),(482,'ידידה'),(483,'ידמרדכי'),(484,'ידנתן'),(485,'ידרמבם'),(486,'יהוד-מונוסון'),(487,'יהל'),(488,'יובל'),(489,'יובלים'),(490,'יודפת'),(491,'יונתן'),(492,'יושיביה'),(493,'יזרעאל'),(494,'יחיעם'),(495,'יטבתה'),(496,'ייטב'),(497,'יכיני'),(498,'ינוב'),(499,'ינון'),(500,'יסודהמעלה'),(501,'יסודות'),(502,'יסעור'),(503,'יעד'),(504,'יעל'),(505,'יעף'),(506,'יערה'),(507,'יפיע'),(508,'יפית'),(509,'יפעת'),(510,'יפתח'),(511,'יצהר'),(512,'יציץ'),(513,'יקום'),(514,'יקיר'),(515,'יקנעם)מושבה('),(516,'יקנעםעילית'),(517,'יראון'),(518,'ירדנה'),(519,'ירוחם'),(520,'ירושלים'),(521,'ירחיב'),(522,'ירכא'),(523,'ירקונה'),(524,'ישע'),(525,'ישעי'),(526,'ישרש'),(527,'יתד'),(528,'יתיר'),(529,'כאבו ל'),(530,'כאוכבאבו אל-היגא'),(531,'כברי'),(532,'כדורי'),(533,'כדיתה'),(534,'כוכבהשחר'),(535,'כוכביאיר'),(536,'כוכביעקב'),(537,'כוכבמיכאל'),(538,'כורזים'),(539,'כחל'),(540,'כחלה'),(541,'כיסופים'),(542,'כישור'),(543,'כליל'),(544,'כלנית'),(545,'כמאנה'),(546,'כמהין'),(547,'כמון'),(548,'כנות'),(549,'כנף'),(550,'כנרת)מושבה('),(551,'כנרת)קבוצה('),(552,'כסיפה'),(553,'כסלון'),(554,'כסרא-סמיע'),(555,'כעביה-טבאש-חגאגרה'),(556,'כפראביב'),(557,'כפראדומים'),(558,'כפראוריה'),(559,'כפראחים'),(560,'כפרביאליק'),(561,'כפרבילו'),(562,'כפרבלום'),(563,'כפרבןנון'),(564,'כפרברא'),(565,'כפרברוך'),(566,'כפרגדעון'),(567,'כפרגלים'),(568,'כפרגליקסון'),(569,'כפרגלעדי'),(570,'כפרדניאל'),(571,'כפרהאורנים'),(572,'כפרהחורש'),(573,'כפרהמכבי'),(574,'כפרהנגיד'),(575,'כפרהנוערהדתי'),(576,'כפרהנשיא'),(577,'כפרהס'),(578,'כפרהראה'),(579,'כפרהריף'),(580,'כפרויתקין'),(581,'כפרורבורג'),(582,'כפרורדים'),(583,'כפרזוהרים'),(584,'כפרזיתים'),(585,'כפרחבד'),(586,'כפרחושן'),(587,'כפרחיטים'),(588,'כפרחיים'),(589,'כפרחנניה'),(590,'כפרחסידיםא'),(591,'כפרחסידיםב'),(592,'כפרחרוב'),(593,'כפרטרומן'),(594,'כפריאסיף'),(595,'כפרידידיה'),(596,'כפריהושע'),(597,'כפריונה'),(598,'כפריחזקאל'),(599,'כפריעבץ'),(600,'כפרכמא'),(601,'כפרכנא'),(602,'כפרמונש'),(603,'כפרמימון'),(604,'כפרמלל'),(605,'כפרמנדא'),(606,'כפרמנחם'),(607,'כפרמסריק'),(608,'כפרמצר'),(609,'כפרמרדכי'),(610,'כפרנטר'),(611,'כפרסאלד'),(612,'כפרסבא'),(613,'כפרסילבר'),(614,'כפרסירקין'),(615,'כפרעבודה'),(616,'כפרעזה'),(617,'כפרעציון'),(618,'כפרפינס'),(619,'כפרקאסם'),(620,'כפרקיש'),(621,'כפרקרע'),(622,'כפרראשהנקרה'),(623,'כפררוזנואלד)זרעית('),(624,'כפררופין'),(625,'כפררות'),(626,'כפרשמאי'),(627,'כפרשמואל'),(628,'כפרשמריהו'),(629,'כפרתבור'),(630,'כפרתפוח'),(631,'כרידשא'),(632,'כרכום'),(633,'כרםבןזמרה'),(634,'כרםבןשמן'),(635,'כרמיאל'),(636,'כרםיבנה)ישיבה('),(637,'כרמיה'),(638,'כרמייוסף'),(639,'כרמים'),(640,'כרמיצור'),(641,'כרמיקטיף'),(642,'כרמל'),(643,'כרםמהרל'),(644,'כרםשלום'),(645,'לארשום'),(646,'לבון'),(647,'לביא'),(648,'לבנים'),(649,'להב'),(650,'להבותהבשן'),(651,'להבותחביבה'),(652,'להבים'),(653,'לוד'),(654,'לוזית'),(655,'לוחמיהגיטאות'),(656,'לוטם'),(657,'לוטן'),(658,'לימן'),(659,'לכיש'),(660,'לפיד'),(661,'לפידות'),(662,'לקיה'),(663,'מאור'),(664,'מאירשפיה'),(665,'מבואביתר'),(666,'מבואדותן'),(667,'מבואותים'),(668,'מבואחורון'),(669,'מבואחמה'),(670,'מבואמודיעים'),(671,'מבועים'),(672,'מבטחים'),(673,'מבקיעים'),(674,'מבשרתציון'),(675,'מגדאל-כרום'),(676,'מגדלשמס'),(677,'מגאר'),(678,'מגדים'),(679,'מגדל'),(680,'מגדלהעמק'),(681,'מגדלים'),(682,'מגדלעוז'),(683,'מגידו'),(684,'מגל'),(685,'מגן'),(686,'מגןשאול'),(687,'מגשימים'),(688,'מדרךעוז'),(689,'מדרשתבןגוריון'),(690,'מדרשתרופין'),(691,'מודיעין-מכבים-רעות'),(692,'מודיעיןעילית'),(693,'מולדה'),(694,'מולדת'),(695,'מוצאעילית'),(696,'מוקייבלה'),(697,'מורן'),(698,'מורשת'),(699,'מזור'),(700,'מזכרתבתיה'),(701,'מזרע'),(702,'מזרעה'),(703,'מחולה'),(704,'מחנההילה'),(705,'מחנהטלי'),(706,'מחנהיהודית'),(707,'מחנהיוכבד'),(708,'מחנהיפה'),(709,'מחנהיתיר'),(710,'מחנהמרים'),(711,'מחנהעדי'),(712,'מחנהתלנוף'),(713,'מחניים'),(714,'מחסיה'),(715,'מטולה'),(716,'מטע'),(717,'מיטב'),(718,'מייסר'),(719,'מיעמי'),(720,'מיצר'),(721,'מירב'),(722,'מירון'),(723,'מישר'),(724,'מיתר'),(725,'מכורה'),(726,'מכחול'),(727,'מכמורת'),(728,'מכמנים'),(729,'מלאה'),(730,'מלילות'),(731,'מלכיה'),(732,'מלכישוע'),(733,'מנוחה'),(734,'מנוף'),(735,'מנות'),(736,'מנחמיה'),(737,'מנרה'),(738,'מנשיתזבדה'),(739,'מסד'),(740,'מסדה'),(741,'מסילות'),(742,'מסילתציון'),(743,'מסלול'),(744,'מסעדה'),(745,'מסעודיןאל-עזאזמה'),(746,'מעברות'),(747,'מעגלים'),(748,'מעגן'),(749,'מעגןמיכאל'),(750,'מעוזחיים'),(751,'מעון'),(752,'מעונה'),(753,'מעיליא'),(754,'מעיןברוך'),(755,'מעיןצבי'),(756,'מעלהאדומים'),(757,'מעלהאפרים'),(758,'מעלהגלבוע'),(759,'מעלהגמלא'),(760,'מעלההחמישה'),(761,'מעלהלבונה'),(762,'מעלהמכמש'),(763,'מעלהעירון'),(764,'מעלהעמוס'),(765,'מעלהשומרון'),(766,'מעלות-תרשיחא'),(767,'מענית'),(768,'מעש'),(769,'מפלסים'),(770,'מצדותיהודה'),(771,'מצובה'),(772,'מצליח'),(773,'מצפה'),(774,'מצפהאביב'),(775,'מצפהאילן'),(776,'מצפהיריחו'),(777,'מצפהנטופה'),(778,'מצפהרמון'),(779,'מצפהשלם'),(780,'מצר'),(781,'מקווהישראל'),(782,'מרגליות'),(783,'מרוםגולן'),(784,'מרחביה)מושב('),(785,'מרחביה(קיבוץ)'),(786,'מרחבעם'),(787,'מרכזשפירא'),(788,'משאבישדה'),(789,'משגבדב'),(790,'משגבעם'),(791,'משהד'),(792,'משואה'),(793,'משואותיצחק'),(794,'משכיות'),(795,'משמראיילון'),(796,'משמרדוד'),(797,'משמרהירדן'),(798,'משמרהנגב'),(799,'משמרהעמק'),(800,'משמרהשבעה'),(801,'משמרהשרון'),(802,'משמרות'),(803,'משמרת'),(804,'משען'),(805,'מתן'),(806,'מתת'),(807,'מתתיהו'),(808,'נאותגולן'),(809,'נאותהכיכר'),(810,'נאותמרדכי'),(811,'נאותסמדר'),(812,'נאעורה'),(813,'נבטים'),(814,'נגבה'),(815,'נגוהות'),(816,'נהורה'),(817,'נהלל'),(818,'נהריה'),(819,'נוב'),(820,'נוגה'),(821,'נווה'),(822,'נווהאבו ת'),(823,'נווהאור'),(824,'נווהאטיב'),(825,'נווהאילן'),(826,'נווהאיתן'),(827,'נווהדניאל'),(828,'נווהזוהר'),(829,'נווהזיו'),(830,'נווהחריף'),(831,'נווהים'),(832,'נווהימין'),(833,'נווהירק'),(834,'נווהמבטח'),(835,'נווהמיכאל'),(836,'נווהשלום'),(837,'נועם'),(838,'נוףאיילון'),(839,'נופים'),(840,'נופית'),(841,'נופך'),(842,'נוקדים'),(843,'נורדיה'),(844,'נורית'),(845,'נחושה'),(846,'נחלה'),(847,'נחליאל'),(848,'נחלים'),(849,'נחלעוז'),(850,'נחם'),(851,'נחף'),(852,'נחשולים'),(853,'נחשון'),(854,'נחשונים'),(855,'נטועה'),(856,'נטור'),(857,'נטע'),(858,'נטעים'),(859,'נטף'),(860,'ניין'),(861,'נילי'),(862,'ניצן'),(863,'ניצןב'),(864,'ניצנה)קהילתחינוך('),(865,'ניצנים'),(866,'ניצניסיני'),(867,'ניצניעוז'),(868,'ניראליהו'),(869,'נירבנים'),(870,'נירגלים'),(871,'נירדוד)תלעמל('),(872,'נירחן'),(873,'נירים'),(874,'ניריפה'),(875,'ניריצחק'),(876,'נירישראל'),(877,'נירית'),(878,'נירמשה'),(879,'נירן'),(880,'נירעוז'),(881,'נירעם'),(882,'נירעציון'),(883,'נירעקיבא'),(884,'נירצבי'),(885,'נמרוד'),(886,'נסהרים'),(887,'נסעמים'),(888,'נסציונה'),(889,'נעורים'),(890,'נעלה'),(891,'נעמה'),(892,'נען'),(893,'נצאצרה'),(894,'נצרחזני'),(895,'נצרסרני'),(896,'נצרת'),(897,'נצרתעילית'),(898,'נשר'),(899,'נתיבהגדוד'),(900,'נתיבהלה'),(901,'נתיבהעשרה'),(902,'נתיבהשיירה'),(903,'נתיבות'),(904,'נתניה'),(905,'סאגור'),(906,'סאסא'),(907,'סביון'),(908,'סגולה'),(909,'סואעד)חמרייה('),(910,'סואעד)כמאנה('),(911,'סולם'),(912,'סוסיה'),(913,'סופה'),(914,'סחנין'),(915,'סייד'),(916,'סלמה'),(917,'סלעית'),(918,'סמר'),(919,'סנסנה'),(920,'סעד'),(921,'סער'),(922,'ספיר'),(923,'סתריה'),(924,'עגר'),(925,'עבדון'),(926,'עברון'),(927,'עגור'),(928,'עדי'),(929,'עדנים'),(930,'עוזה'),(931,'עוזייר'),(932,'עולש'),(933,'עומר'),(934,'עופר'),(935,'עופרה'),(936,'עוצם'),(937,'עוקבי)בנועוקבה('),(938,'עזוז'),(939,'עזר'),(940,'עזריאל'),(941,'עזריה'),(942,'עזריקם'),(943,'עטאוונה'),(944,'עטרת'),(945,'עידן'),(946,'עיילבון'),(947,'עיינות'),(948,'עילוט'),(949,'עיןאיילה'),(950,'עיןאל-אסד'),(951,'עיןגב'),(952,'עיןגדי'),(953,'עיןדור'),(954,'עיןהבשור'),(955,'עיןהוד'),(956,'עיןהחורש'),(957,'עיןהמפרץ'),(958,'עיןהנציב'),(959,'עיןהעמק'),(960,'עיןהשופט'),(961,'עיןהשלושה'),(962,'עיןורד'),(963,'עיןזיוון'),(964,'עיןחוד'),(965,'עיןחצבה'),(966,'עיןחרוד(איחוד)'),(967,'עיןחרוד(מאוחד)'),(968,'עיןיהב'),(969,'עיןיעקב'),(970,'עיןכרם-ביסחקלאי'),(971,'עיןכרמל'),(972,'עיןמאהל'),(973,'עיןנקובא'),(974,'עיןעירון'),(975,'עיןצורים'),(976,'עיןקנייא'),(977,'עיןראפה'),(978,'עיןשמר'),(979,'עיןשריד'),(980,'עינת'),(981,'עיןתמר'),(982,'עיראובות'),(983,'עכו'),(984,'עלומים'),(985,'עלי'),(986,'עליזהב'),(987,'עלמה'),(988,'עלמון'),(989,'עמוקה'),(990,'עמינדב'),(991,'עמיעד'),(992,'עמיעוז'),(993,'עמיקם'),(994,'עמיר'),(995,'עמנואל'),(996,'עמקה'),(997,'ענב'),(998,'עספיא'),(999,'עפולה'),(1000,'עץאפרים'),(1001,'עצמוןשגב'),(1002,'עראבה'),(1003,'עראמשה'),(1004,'ערבאלנעים'),(1005,'ערד'),(1006,'ערוגות'),(1007,'ערערה'),(1008,'ערערה-בנגב'),(1009,'עשרת'),(1010,'עתלית'),(1011,'עתניאל'),(1012,'פארן'),(1013,'פדואל'),(1014,'פדויים'),(1015,'פדיה'),(1016,'פוריה-כפרעבודה'),(1017,'פוריה-נווהעובד'),(1018,'פוריהעילית'),(1019,'פוריידיס'),(1020,'פורת'),(1021,'פטיש'),(1022,'פלך'),(1023,'פלמחים'),(1024,'פניחבר'),(1025,'פסגות'),(1026,'פסוטה'),(1027,'פעמיתשז'),(1028,'פצאל'),(1029,'פקיעין)בוקייעה('),(1030,'פקיעיןחדשה'),(1031,'פרדסחנה-כרכור'),(1032,'פרדסיה'),(1033,'פרוד'),(1034,'פרזון'),(1035,'פריגן'),(1036,'פתחיה'),(1037,'פתחתקווה'),(1038,'צאלים'),(1039,'צביה'),(1040,'צבעון'),(1041,'צובה'),(1042,'צוחר'),(1043,'צופיה'),(1044,'צופים'),(1045,'צופית'),(1046,'צופר'),(1047,'צוקיים'),(1048,'צוקים'),(1049,'צורהדסה'),(1050,'צוריאל'),(1051,'צוריצחק'),(1052,'צורית'),(1053,'צורמשה'),(1054,'צורנתן'),(1055,'ציפורי'),(1056,'צלפון'),(1057,'צנדלה'),(1058,'צפריה'),(1059,'צפרירים'),(1060,'צפת'),(1061,'צרופה'),(1062,'צרעה'),(1063,'קבועה'),(1064,'קבוצתיבנה'),(1065,'קדומים'),(1066,'קדימה-צורן'),(1067,'קדמה'),(1068,'קדמתצבי'),(1069,'קדר'),(1070,'קדרון'),(1071,'קדרים'),(1072,'קודייראתא-צאנע'),(1073,'קוואעין'),(1074,'קוממיות'),(1075,'קורנית'),(1076,'קטורה'),(1077,'קיסריה'),(1078,'קלחים'),(1079,'קליה'),(1080,'קלנסווה'),(1081,'קלע'),(1082,'קציר'),(1083,'קצרא-סר'),(1084,'קצרין'),(1085,'קריתאונו'),(1086,'קריתארבע'),(1087,'קריתאתא'),(1088,'קריתביאליק'),(1089,'קריתגת'),(1090,'קריתטבעון'),(1091,'קריתים'),(1092,'קריתיערים'),(1093,'קריתיערים)מוסד('),(1094,'קריתמוצקין'),(1095,'קריתמלאכי'),(1096,'קריתנטפים'),(1097,'קריתענבים'),(1098,'קריתעקרון'),(1099,'קריתשלמה'),(1100,'קריתשמונה'),(1101,'קרנישומרון'),(1102,'קשת'),(1103,'ראמה'),(1104,'ראסאל-עין'),(1105,'ראסעלי'),(1106,'ראשהעין'),(1107,'ראשוןלציון'),(1108,'ראשפינה'),(1109,'ראשצורים'),(1110,'רבבה'),(1111,'רבדים'),(1112,'רביבים'),(1113,'רביד'),(1114,'רגבה'),(1115,'רגבים'),(1116,'רהט'),(1117,'רווחה'),(1118,'רוויה'),(1119,'רוחמדבר'),(1120,'רוחמה'),(1121,'רומאנה'),(1122,'רומתהייב'),(1123,'רועי'),(1124,'רותם'),(1125,'רחוב'),(1126,'רחובות'),(1127,'רחלים'),(1128,'ריחאניה'),(1129,'ריחן'),(1130,'ריינה'),(1131,'רימונים'),(1132,'רינתיה'),(1133,'רכסים'),(1134,'רם-און'),(1135,'רמות'),(1136,'רמותהשבים'),(1137,'רמותמאיר'),(1138,'רמותמנשה'),(1139,'רמותנפתלי'),(1140,'רמלה'),(1141,'רמתגן'),(1142,'רמתדוד'),(1143,'רמתהכובש'),(1144,'רמתהשופט'),(1145,'רמתהשרון'),(1146,'רמתיוחנן'),(1147,'רמתישי'),(1148,'רמתמגשימים'),(1149,'רמתצבי'),(1150,'רמתרזיאל'),(1151,'רמתרחל'),(1152,'רנן'),(1153,'רעים'),(1154,'רעננה'),(1155,'רקפת'),(1156,'רשפון'),(1157,'רשפים'),(1158,'רתמים'),(1159,'שארישוב'),(1160,'שביציון'),(1161,'שבישומרון'),(1162,'שבלי-אוםאל-גנם'),(1163,'שגב-שלום'),(1164,'שדהאילן'),(1165,'שדהאליהו'),(1166,'שדהאליעזר'),(1167,'שדהבוקר'),(1168,'שדהדוד'),(1169,'שדהורבורג'),(1170,'שדהיואב'),(1171,'שדהיעקב'),(1172,'שדהיצחק'),(1173,'שדהמשה'),(1174,'שדהנחום'),(1175,'שדהנחמיה'),(1176,'שדהניצן'),(1177,'שדהעוזיהו'),(1178,'שדהצבי'),(1179,'שדותים'),(1180,'שדותמיכה'),(1181,'שדיאברהם'),(1182,'שדיחמד'),(1183,'שדיתרומות'),(1184,'שדמה'),(1185,'שדמותדבורה'),(1186,'שדמותמחולה'),(1187,'שדרות'),(1188,'שואבה'),(1189,'שובה'),(1190,'שובל'),(1191,'שוהם'),(1192,'שומרה'),(1193,'שומריה'),(1194,'שוקדה'),(1195,'שורש'),(1196,'שורשים'),(1197,'שושנתהעמקים'),(1198,'שזור'),(1199,'שחר'),(1200,'שחרות'),(1201,'שיבולים'),(1202,'שיטים'),(1203,'שייחדנון'),(1204,'שילה'),(1205,'שילת'),(1206,'שכניה'),(1207,'שלווה'),(1208,'שלווהבמדבר'),(1209,'שלוחות'),(1210,'שלומי'),(1211,'שלומית'),(1212,'שמיר'),(1213,'שמעה'),(1214,'שמרת'),(1215,'שמשית'),(1216,'שני'),(1217,'שניר'),(1218,'שעב'),(1219,'שעורים'),(1220,'שעל'),(1221,'שעלבים'),(1222,'שעראפרים'),(1223,'שערהגולן'),(1224,'שערהעמקים'),(1225,'שעריתקווה'),(1226,'שערמנשה'),(1227,'שפיים'),(1228,'שפיר'),(1229,'שפר'),(1230,'שפרעם'),(1231,'שקד'),(1232,'שקף'),(1233,'שרונה'),(1234,'שריגים לי-און'),(1235,'שריד'),(1236,'שרשרת'),(1237,'שתולה'),(1238,'שתולים'),(1239,'תאשור'),(1240,'תדהר'),(1241,'תובל'),(1242,'תומר'),(1243,'תושיה'),(1244,'תימורים'),(1245,'תירוש'),(1246,'תלאביב-יפו'),(1247,'תליוסף'),(1248,'תליצחק'),(1249,'תלם'),(1250,'תלמונד'),(1251,'תלמי אליהו'),(1252,'תלמי אלעזר'),(1253,'תלמי בילו'),(1254,'תלמי יוסף'),(1255,'תלמי  יחיאל'),(1256,'תל מייפה'),(1257,'תלמי ם'),(1258,'תל עדשים'),(1259,'תלקציר'),(1260,'תלשבע'),(1261,'תלת אומים'),(1262,'תמרת'),(1263,'תנובות'),(1264,'תעוז'),(1265,'תפרח'),(1266,'תקומה'),(1267,'תקוע'),(1268,'תראביןא-צאנע'),(1269,'תראביןא-צאנע'),(1270,'תרום');

/*Table structure for table `country_codes` */

DROP TABLE IF EXISTS `country_codes`;

CREATE TABLE `country_codes` (
  `country` int(11) NOT NULL AUTO_INCREMENT,
  `country_name` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`country`)
) ENGINE=InnoDB AUTO_INCREMENT=193 DEFAULT CHARSET=utf16le;

/*Data for the table `country_codes` */

insert  into `country_codes`(`country`,`country_name`) values (1,'N/A'),(2,'אוגנדה'),(3,'אוזבקיסטן'),(4,'אוסטריה'),(5,'אוסטרליה'),(6,'אוקראינה'),(7,'אורוגוואי'),(8,'אזרבייג`ן'),(9,'איחוד האמירויות הערביות'),(10,'איטליה'),(11,'איי בהאמה'),(12,'איי מרשל'),(13,'איי שלמה'),(14,'אינדונזיה'),(15,'איסלנד'),(16,'איראן'),(17,'אירלנד'),(18,'אל סלוודור'),(19,'אלבניה'),(20,'אלג`יריה'),(21,'אנגולה'),(22,'אנדורה'),(23,'אנטיגואה וברבודה'),(24,'אסטוניה'),(25,'אפגניסטן'),(26,'אקוודור'),(27,'ארגנטינה'),(28,'אריתריאה'),(29,'ארמניה'),(30,'ארצות הברית'),(31,'אתיופיה'),(32,'בהוטן'),(33,'בוטסואנה'),(34,'בולגריה'),(35,'בוליביה'),(36,'בוסניה והרצגובינה'),(37,'בורונדי'),(38,'בורקינה פאסו'),(39,'בחריין'),(40,'בלארוס'),(41,'בלגיה'),(42,'בליז'),(43,'בנגלדש'),(44,'בנין'),(45,'ברוניי'),(46,'ברזיל'),(47,'ג`יבוטי'),(48,'ג`מייקה'),(49,'גאורגיה'),(50,'גאנה'),(51,'גבון'),(52,'גואטמלה'),(53,'גיאנה'),(54,'גינאה'),(55,'גינאה ביסאו'),(56,'גינאה המשוונית'),(57,'גמביה'),(58,'גרמניה'),(59,'דומיניקה'),(60,'דנמרק'),(61,'דרום אפריקה'),(62,'דרום סודאן'),(63,'האיטי'),(64,'האיים המלדיביים'),(65,'הודו'),(66,'הולנד'),(67,'הונגריה'),(68,'הונדורס'),(69,'המדינה האסלאמית'),(70,'הממלכה המאוחדת'),(71,'הפיליפינים'),(72,'הרפובליקה הדומיניקנית'),(73,'הרפובליקה הדמוקרטית של קונגו'),(74,'הרפובליקה המרכז-אפריקאית'),(75,'הרפובליקה העממית של סין'),(76,'הרפובליקה של קונגו'),(77,'וייטנאם'),(78,'ונואטו'),(79,'ונצואלה'),(80,'קריית הוותיקן'),(81,'זימבבואה'),(82,'זמביה'),(83,'חוף השנהב'),(84,'טאיוואן'),(85,'טג`יקיסטן'),(86,'טובאלו'),(87,'טוגו'),(88,'טונגה'),(89,'טורקיה'),(90,'טורקמניסטן'),(91,'טנזניה'),(92,'טרינידד וטובגו'),(93,'יוון'),(94,'יפן'),(95,'ירדן'),(96,'ישראל'),(97,'כווית'),(98,'לאוס'),(99,'לבנון'),(100,'לוב'),(101,'לוקסמבורג'),(102,'לטביה'),(103,'ליבריה'),(104,'ליטא'),(105,'ליכטנשטיין'),(106,'לסוטו'),(107,'מאוריטניה'),(108,'מאוריציוס'),(109,'מאלי'),(110,'מדגסקר'),(111,'מוזמביק'),(112,'מולדובה'),(113,'מונאקו'),(114,'מונגוליה'),(115,'מונטנגרו'),(116,'מזרח טימור'),(117,'מיאנמר'),(118,'מיקרונזיה'),(119,'מלאווי'),(120,'מלזיה'),(121,'מלטה'),(122,'מצרים'),(123,'מקדוניה'),(124,'מקסיקו'),(125,'מרוקו'),(126,'נאורו'),(127,'נורווגיה'),(128,'ניגריה'),(129,'ניו זילנד'),(130,'ניז`ר'),(131,'ניקרגואה'),(132,'נמיביה'),(133,'נפאל'),(134,'סאו טומה ופרינסיפה'),(135,'סודאן'),(136,'סווזילנד'),(137,'סומליה'),(138,'סומלילנד'),(139,'סוריה'),(140,'סורינאם'),(141,'סיירה לאון'),(142,'סין'),(143,'סלובניה'),(144,'סלובקיה'),(145,'סמואה'),(146,'סן מרינו'),(147,'סנגל'),(148,'סנט וינסנט והגרנדינים'),(149,'סנט קיטס ונוויס'),(150,'ספרד'),(151,'סרביה'),(152,'סרי לנקה'),(153,'עומאן'),(154,'עיראק'),(155,'ערב הסעודית'),(156,'פולין'),(157,'פורטוגל'),(158,'פיג`י'),(159,'פינלנד'),(160,'פנמה'),(161,'פקיסטן'),(162,'פרגוואי'),(163,'פרו'),(164,'צ`אד'),(165,'צ`ילה'),(166,'צ`כיה'),(167,'צרפת'),(168,'קובה'),(169,'קולומביה'),(170,'קומורו'),(171,'קוסטה ריקה'),(172,'קוריאה הדרומית'),(173,'קוריאה הצפונית'),(174,'קזחסטן'),(175,'קטר (מדינה)'),(176,'קירגיזסטן'),(177,'קיריבטי'),(178,'קמבודיה'),(179,'קמרון'),(180,'קנדה'),(181,'קניה'),(182,'קפריסין'),(183,'קרואטיה'),(184,'רואנדה'),(185,'רומניה'),(186,'רוסיה'),(187,'רפובליקת סהרה הערבית הדמוקרטית'),(188,'שוודיה'),(189,'שווייץ'),(190,'תאילנד'),(191,'תוניסיה'),(192,'תימן');

/*Table structure for table `departments` */

DROP TABLE IF EXISTS `departments`;

CREATE TABLE `departments` (
  `dcode` int(10) NOT NULL AUTO_INCREMENT,
  `dname` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dlocation` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dmngr` varchar(35) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dphone` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`dcode`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf16le;

/*Data for the table `departments` */

insert  into `departments`(`dcode`,`dname`,`dlocation`,`dmngr`,`dphone`) values (1,'Admin','Hell','Admin','1234');

/*Table structure for table `employees` */

DROP TABLE IF EXISTS `employees`;

CREATE TABLE `employees` (
  `eid` bigint(9) NOT NULL AUTO_INCREMENT COMMENT 'Employee ID',
  `id` bigint(9) NOT NULL DEFAULT '0' COMMENT 'Social Security ID',
  `passwd` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Password',
  `userlogin` int(11) NOT NULL DEFAULT '0' COMMENT 'Can User login',
  `userprofile` int(11) NOT NULL DEFAULT '1' COMMENT 'Access to user menu',
  `ishr` int(11) NOT NULL DEFAULT '0' COMMENT 'Is user part of HR',
  `addp` int(11) NOT NULL DEFAULT '0' COMMENT 'Add Employee',
  `alterp` int(11) NOT NULL DEFAULT '0' COMMENT 'Edit Employee',
  `hours` int(11) NOT NULL DEFAULT '0' COMMENT 'See Hours Report',
  `fname` varchar(35) CHARACTER SET hebrew NOT NULL COMMENT 'First Name',
  `lname` varchar(35) CHARACTER SET utf8mb4 NOT NULL COMMENT 'Last Name',
  `gender` varchar(6) CHARACTER SET utf8mb4 NOT NULL COMMENT 'Did you assume my gender',
  `dob` date NOT NULL COMMENT 'Date of Birth',
  `address` varchar(50) CHARACTER SET utf8mb4 NOT NULL COMMENT 'Street Address',
  `zip` varchar(10) NOT NULL DEFAULT '0' COMMENT 'Zip Code',
  `city` int(9) NOT NULL COMMENT 'City Code',
  `country` int(9) NOT NULL COMMENT 'Country Code',
  `cob` int(9) NOT NULL COMMENT 'Country of Birth',
  `mdate` date DEFAULT NULL COMMENT 'Migration Date',
  `married` int(10) NOT NULL DEFAULT '0' COMMENT 'Marrital state',
  `children` int(2) NOT NULL DEFAULT '0' COMMENT 'Children Amount',
  `sdate` date NOT NULL COMMENT 'Start Work Date',
  `endate` date DEFAULT '1990-01-01' COMMENT 'End work date',
  `job_type` int(1) NOT NULL COMMENT 'Job Type Code',
  `wage_class` int(1) NOT NULL COMMENT 'Wage Class Code',
  `dcode` int(10) NOT NULL COMMENT 'Department Code',
  PRIMARY KEY (`eid`),
  KEY `city` (`city`),
  KEY `country` (`country`),
  KEY `cob` (`cob`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf16le;

/*Data for the table `employees` */

insert  into `employees`(`eid`,`id`,`passwd`,`userlogin`,`userprofile`,`ishr`,`addp`,`alterp`,`hours`,`fname`,`lname`,`gender`,`dob`,`address`,`zip`,`city`,`country`,`cob`,`mdate`,`married`,`children`,`sdate`,`endate`,`job_type`,`wage_class`,`dcode`) values (1,1234,'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==',1,1,1,1,1,1,'admin','admin','male','2017-12-01','1234 street','1234',1,1,1,'2017-12-01',1,1,'2017-12-01','2017-12-01',1,1,1),(11,123456789,'+lhdichR3TOKcNz1Naoqkv7ng23Wr/EiZYPojgmWKT8WvACcZSgm4PxccGaVoDzdzjcvE57/TROVnabx9dPqvg==',0,0,1,0,0,0,'Test','Test','זכר','2017-12-27','Test','1234',0,0,0,'2017-12-27',1,2,'2017-12-27','2017-12-01',1,1,1),(12,987654321,'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==',0,0,1,0,0,0,'TEst','TEst','זכר','2017-12-27','TEst','12346',0,0,0,'2017-12-23',1,3,'2017-12-26','2017-12-01',1,1,1),(13,186574974,'+kCH0hyTdsiN5puNyXZrZILYIsGNKYgkBnuaJRDM2ph+KiayDovUMpwPdXu5z4ZKIUNeCw7ntJrSjr4EaZ9gYQ==',0,0,1,0,0,0,'Blyat','Blyat','זכר','1990-04-13','Blyat','1858949',1,1,1,'1997-04-06',3,2,'2014-11-01','2017-12-01',1,1,1),(14,741085296,'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==',0,0,1,0,0,0,'בלאט','סוקה','זכר','2017-12-20','סוקה בלאט','132345',6,11,17,'2017-12-27',3,3,'2017-12-27','2017-12-01',1,1,1),(15,852963741,'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==',0,0,0,0,0,0,'ישראל','ישראלוב','זכר','2004-01-26','ישראל 18','89011',520,96,1,'2017-12-27',1,4,'2017-12-27','2017-12-01',0,0,1);

/*Table structure for table `reports` */

DROP TABLE IF EXISTS `reports`;

CREATE TABLE `reports` (
  `eid` bigint(20) NOT NULL,
  `id` bigint(9) NOT NULL DEFAULT '0',
  `enter_time` datetime DEFAULT NULL,
  `exit_time` datetime DEFAULT NULL,
  `total_hours` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16le;

/*Data for the table `reports` */

insert  into `reports`(`eid`,`id`,`enter_time`,`exit_time`,`total_hours`) values (15,852963741,'2017-12-30 06:25:52','2017-12-30 12:47:55',6.367689485916666);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
