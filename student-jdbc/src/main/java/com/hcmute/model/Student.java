package com.hcmute.model;

public class Student {

	public String getMssv() {
		return Mssv;
	}
	public void setMssv(String mssv) {
		Mssv = mssv;
	}
	public String getHoten() {
		return Hoten;
	}
	public void setHoten(String hoten) {
		Hoten = hoten;
	}
	public String getGioiTinh() {
		return GioiTinh;
	}
	@Override
	public String toString() {
		return "Student [Mssv=" + Mssv + ", Hoten=" + Hoten + ", GioiTinh=" + GioiTinh + ", NgaySinh=" + NgaySinh
				+ ", Khoa=" + Khoa + ", Sdt=" + Sdt + ", TinhTrang=" + TinhTrang + "]";
	}
	public void setGioiTinh(String gioiTinh) {
		GioiTinh = gioiTinh;
	}
	public String getNgaySinh() {
		return NgaySinh;
	}
	public void setNgaySinh(String ngaySinh) {
		NgaySinh = ngaySinh;
	}
	public String getKhoa() {
		return Khoa;
	}
	public void setKhoa(String khoa) {
		Khoa = khoa;
	}
	public String getSdt() {
		return Sdt;
	}
	public void setSdt(String sdt) {
		Sdt = sdt;
	}
	public Boolean getTinhTrang() {
		return TinhTrang;
	}
	public void setTinhTrang(Boolean tinhTrang) {
		TinhTrang = tinhTrang;
	}
	private String Mssv;	
	private String Hoten;
	private String GioiTinh;
	private String NgaySinh;
	private String Khoa;
	private String Sdt;
	private Boolean TinhTrang;

	

}