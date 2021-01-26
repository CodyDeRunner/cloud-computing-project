package com.hcmute.dao;


import org.springframework.jdbc.core.RowMapper;

import java.sql.ResultSet;
import java.sql.SQLException;
import com.hcmute.model.Student;

public class StudentRowMapper implements RowMapper<Student> {
    @Override
    public Student mapRow(ResultSet rs, int rowNum) throws SQLException {

    	Student std = new Student();
    	std.setMssv(rs.getString("Mssv"));
    	std.setHoten(rs.getString("HoTen"));
    	std.setGioiTinh(rs.getString("GioiTinh"));
    	std.setNgaySinh(rs.getString("NgaySinh"));
    	std.setKhoa(rs.getString("Khoa"));    	
    	std.setSdt(rs.getString("Sdt"));
    	std.setTinhTrang(rs.getBoolean("TinhTrang"));
    	
        return std;
    }
}