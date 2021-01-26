SET NAMES 'utf8';
CREATE TABLE IF NOT EXISTS student (
	Mssv VARCHAR(10) NOT NULL,
	HoTen VARCHAR(100) NOT NULL,
	GioiTinh varchar(5) NULL,
	NgaySinh varchar(10) NULL,
	Khoa varchar(50) NULL,
	Sdt varchar(10) NULL,
	TinhTrang boolean,
	PRIMARY KEY (Mssv)
);

INSERT `student` VALUES ('11', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('4', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('5', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('6', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('7', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('8', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('9', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('10', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('2', 'Nguyễn Đình A', 'Nam', '1999-11-01', 'CLC', '123456', false);
INSERT `student` VALUES ('3', 'Nguyễn Văn B', 'Nữ', '1999-11-02', 'Sv', '123456', false);
INSERT `student` VALUES ('17110337', 'Huỳnh Văn Ngoãn', 'Nam', '1999-09-24', 'CNTT', '0978980537', false);
INSERT `student` VALUES ('17110392', 'Nguyễn Đình Trọng', 'Nam', '1999-01-01', 'CNTT', '0967854637', false);