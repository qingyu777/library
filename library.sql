SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `admin_id` int(11) NOT NULL AUTO_INCREMENT,
  `admin_username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `admin_passward` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`admin_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES (1, 'admin', 'admin');
INSERT INTO `admin` VALUES (2, 'aaa', 'asdasd');

-- ----------------------------
-- Table structure for book
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book`  (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `book_type` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `book_author` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `book_location` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `book_number` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`book_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of book
-- ----------------------------
INSERT INTO `book` VALUES (1, 'saefgweg', '小说', 'tom', '2厅3-6', 10);
INSERT INTO `book` VALUES (2, '《牛》', '生物', '牛的作者', '1厅1-1', 20);
INSERT INTO `book` VALUES (3, '《鸟》', '生物', '王大锤', '1厅1-2', 20);
INSERT INTO `book` VALUES (4, '《高等数学1》', '数学', '丁一', '2厅1-3', 20);
INSERT INTO `book` VALUES (5, '《数学的奥秘》', '数学', '周建', '2厅1-1', 20);
INSERT INTO `book` VALUES (6, '《我爱我家》', '生活', '马冬梅', '1厅3-2', 20);
INSERT INTO `book` VALUES (7, '《回家的诱惑》', '生活', '孙红雷', '1厅3-8', 20);
INSERT INTO `book` VALUES (8, '《赌徒》', '小说', '赵二', '1厅5-1', 20);
INSERT INTO `book` VALUES (9, '《雪中悍刀行》', '小说', '烽火戏诸侯', '1厅5-3', 20);
INSERT INTO `book` VALUES (10, 'bot', '小说', 'tom', '1厅5-3', 10);
INSERT INTO `book` VALUES (11, 'aaa', '小说', 'tom', '1厅2-3', 15);
INSERT INTO `book` VALUES (12, '《斗破苍穹》', '新小说', '天蚕土豆', '2厅2-4', 30);
INSERT INTO `book` VALUES (14, 'C++入门', '编程', 'ccc', '一楼', 10);

-- ----------------------------
-- Table structure for borrowRecord
-- ----------------------------
DROP TABLE IF EXISTS `borrowRecord`;
CREATE TABLE `borrowRecord`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `book_id` int(11) NULL DEFAULT NULL,
  `student_id` int(11) NULL DEFAULT NULL,
  `status_borrow` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `time_borrow` datetime(0) NULL DEFAULT CURRENT_TIMESTAMP(0),
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `record_book`(`book_id`) USING BTREE,
  INDEX `record_student`(`student_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of borrowRecord
-- ----------------------------
INSERT INTO `borrowRecord` VALUES (1, 1, 1, 'jcwh', '2019-05-30 20:11:15');
INSERT INTO `borrowRecord` VALUES (2, 1, 3, 'jcwh', '2019-05-30 20:11:44');
INSERT INTO `borrowRecord` VALUES (3, 3, 2, 'yihuan', '2019-05-30 20:12:02');
INSERT INTO `borrowRecord` VALUES (4, 7, 1, 'yihuan', '2019-05-31 22:01:40');
INSERT INTO `borrowRecord` VALUES (5, 5, 7, 'jcwh', '2019-05-31 22:44:32');
INSERT INTO `borrowRecord` VALUES (6, 2, 7, 'yihuan', '2019-05-31 22:44:43');
INSERT INTO `borrowRecord` VALUES (7, 4, 2, 'jcwh', '2019-06-01 13:23:09');
INSERT INTO `borrowRecord` VALUES (8, 3, 6, 'jcwh', '2019-06-01 13:23:41');
INSERT INTO `borrowRecord` VALUES (9, 7, 2, 'jcwh', '2019-06-01 13:27:45');
INSERT INTO `borrowRecord` VALUES (10, 6, 7, 'yihuan', '2019-06-01 17:36:01');
INSERT INTO `borrowRecord` VALUES (11, 10, 7, 'jcwh', '2019-06-01 17:39:44');
INSERT INTO `borrowRecord` VALUES (12, 8, 7, 'jcwh', '2019-06-01 17:42:21');
INSERT INTO `borrowRecord` VALUES (13, 3, 7, 'jcwh', '2019-06-01 17:55:42');
INSERT INTO `borrowRecord` VALUES (14, 2, 7, 'jcwh', '2019-06-01 18:20:46');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `student_id` int(11) NOT NULL AUTO_INCREMENT,
  `student_username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `student_passward` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`student_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES (1, '123', '12');
INSERT INTO `student` VALUES (2, '1234', '1234');
INSERT INTO `student` VALUES (3, '12345', '12');
INSERT INTO `student` VALUES (4, '123456', '12');
INSERT INTO `student` VALUES (5, '1234567', '12');
INSERT INTO `student` VALUES (6, '12345678', '123');
INSERT INTO `student` VALUES (7, '12', '12');
INSERT INTO `student` VALUES (8, '1', '12');

SET FOREIGN_KEY_CHECKS = 1;
