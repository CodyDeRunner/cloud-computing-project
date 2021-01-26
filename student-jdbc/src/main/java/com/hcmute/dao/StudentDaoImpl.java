package com.hcmute.dao;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import java.lang.String;

import javax.annotation.PostConstruct;
import javax.sql.DataSource;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.support.JdbcDaoSupport;
import org.springframework.stereotype.Repository;

import com.hcmute.dao.StudentDao;
import com.hcmute.model.Student;


@Repository
public class StudentDaoImpl extends JdbcDaoSupport implements StudentDao {

	@Autowired
	DataSource dataSource;

	@PostConstruct
	private void initialize() {
		setDataSource(dataSource);
	}

	@Override
	public List<Student> getAllStudents() {
		String sql = "SELECT * FROM student";
		List<Map<String, Object>> rows = getJdbcTemplate().queryForList(sql);

		List<Student> result = new ArrayList<Student>();
		for (Map<String, Object> row : rows) {
			Student std = new Student();
			std.setMssv((String) row.get("Mssv"));
			std.setHoten((String) row.get("HoTen"));
			std.setGioiTinh((String) row.get("GioiTinh"));
			std.setNgaySinh((String) row.get("NgaySinh"));
			std.setKhoa((String) row.get("Khoa"));
			std.setSdt((String) row.get("Sdt"));
			std.setTinhTrang((Boolean) row.get("TinhTrang"));
			result.add(std);
		}

		return result;
	}

	@Override
	public void insertStudent(Student student) {
		String sql = "INSERT INTO student " + "(Mssv, HoTen, GioiTinh, NgaySinh, Khoa, Sdt, TinhTrang) VALUES (?, ?, ?, ?, ?, ?, ?)";
		getJdbcTemplate().update(sql, new Object[] { student.getMssv(), student.getHoten(), student.getGioiTinh(), student.getNgaySinh(), student.getKhoa(), student.getSdt(), student.getTinhTrang() });

	}
	
	@Override
	public Student getStudentById(String id) {
		String sql = "SELECT * FROM student WHERE Mssv = ?";		

        return getJdbcTemplate().queryForObject(sql, new Object[]{id}, new StudentRowMapper());
	}
	
	@Override
	public void editStudent(Student student, String id) {
		String sqlFullName = "UPDATE student SET HoTen = IF (? IS NOT NULL, ?, HoTen) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlFullName, new Object[] { student.getHoten(), student.getHoten(), id });
		
		String sqlGender = "UPDATE student SET GioiTinh = IF (? IS NOT NULL, ?, GioiTinh) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlGender, new Object[] { student.getGioiTinh(), student.getGioiTinh(), id });
		
		String sqlBirthday = "UPDATE student SET NgaySinh = IF (? IS NOT NULL, ?, NgaySinh) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlBirthday, new Object[] { student.getNgaySinh(), student.getNgaySinh(), id });
		
		String sqlAddress = "UPDATE student SET Khoa = IF (? IS NOT NULL, ?, Khoa) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlAddress, new Object[] { student.getKhoa(), student.getKhoa(), id });
		
		String sqlPhone = "UPDATE student SET Sdt = IF (? IS NOT NULL, ?, Sdt) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlPhone, new Object[] { student.getSdt(), student.getSdt(), id });
		
		String sqlIsDelete = "UPDATE student SET TinhTrang = IF (? IS NOT NULL, ?, TinhTrang) WHERE  Mssv = ?";
		getJdbcTemplate().update(sqlIsDelete, new Object[] { student.getTinhTrang(), student.getTinhTrang(), id });
	}
}