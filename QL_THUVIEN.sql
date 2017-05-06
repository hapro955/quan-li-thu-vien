create database QL_THUVIEN

--bang nhom sach
create table nhomsach(
	ma_nhomsach varchar(10) not null,
	tennhomsach nvarchar(100) null,
	primary key (ma_nhomsach)
)

--bang dau sach
create table dausach(
	ma_dausach varchar(10) not null,
	ma_nhomsach varchar(10) not null,
	ngonngu nvarchar(20) null, 
	tomtat nvarchar(200) null,
	trangthai int null,
	primary key(ma_dausach),
	foreign key(ma_nhomsach) references nhomsach(ma_nhomsach)

)
alter table dausach  alter column ma_nhomsach varchar(10) null
alter table dausach add   tendausach nvarchar(100) null
--bang doc gia
create table docgia(
	ma_docgia varchar(10) not null,
	hoten nvarchar(50) not null,
	sodienthoai varchar(15) null,
	primary key(ma_docgia)
)
alter table docgia add hinhanh varchar(20) null
--bang the doc gia
create table thedocgia(
	ma_thedocgia varchar(10) not null,
	ma_docgia varchar(10) not null,
	ngaylamthe date not null, 
	ngayhethan date not null, 
	primary key(ma_thedocgia),
	foreign key (ma_docgia) references docgia(ma_docgia)
)
--bang dang ki
create table dangki(
	ma_dausach varchar(10) not null,
	ma_docgia varchar(10) not null,
	ngaydangki date not null,
	ghichu nvarchar(100) null,
	primary key(ma_dausach,ma_docgia)

)
alter table dangki add foreign key(ma_dausach) references dausach(ma_dausach) 
alter table dangki add foreign key(ma_docgia) references docgia(ma_docgia) 
--bang phieu muon
create table phieumuon(
	ma_phieumuon varchar(10) not null,
	ma_docgia varchar(10) not null,
	ngaymuon date not null, 
	ngaytra date not null,
	primary key(ma_phieumuon),
	foreign key(ma_docgia) references docgia(ma_docgia),

)
--bang phieu tra
create table phieutra(
	ma_phieutra varchar(10) not null, 
	ma_phieumuon varchar(10) not null,
	ngaytrathat date not null,
	tienphat float null,
	primary key (ma_phieutra),
	foreign key (ma_phieumuon) references phieumuon(ma_phieumuon)
)
--bang cuon sach
create table cuonsach(
	ma_cuonsach varchar(13) not null,
	ma_phieumuon varchar(10) null,
	ma_dausach varchar(10) not null,
	tinhtrang nvarchar(30) null,
	primary key(ma_cuonsach),
	foreign key (ma_phieumuon) references phieumuon(ma_phieumuon),
	foreign key (ma_dausach) references dausach(ma_dausach)

)
	-- function id môn học tự đông tăng
	create function func_nextID(@lastID varchar(10), @macodinh varchar(4), @size int )
		returns varchar(50)
	as
		begin
			if(@lastID='')
				set @lastID = @macodinh + REPLICATE(0,@size - len(@macodinh))
			declare @nextID varchar(50), @num_nextID int 
			set @lastID= LTRIM(RTRIM(@lastID))
			set @num_nextID= REPLACE(@lastID,@macodinh,'') + 1
			set @nextID= @macodinh + RIGHT(REPLICATE(0,@size) + convert(varchar,@num_nextID),@size - len(@macodinh))
			return @nextID
		end
	--trigger tự động sinh mã nhóm sách 
	create trigger trg_nextIDnhomsach on nhomsach for insert
	as
		begin
			declare @lastID varchar(50)
			set @lastID= (select top 1 ma_nhomsach from nhomsach order by ma_nhomsach desc)
			update nhomsach
			set ma_nhomsach = dbo.func_nextID(@lastID,'NS',6)
			where ma_nhomsach= ''
	end
	--thêm nhóm sách
	create proc nhomsach_them
	@ma varchar(10), @ten nvarchar(100)
	as
		begin
			insert into nhomsach(ma_nhomsach, tennhomsach) values(@ma, @ten)
		end
	--sửa nhóm sách
	create proc nhomsach_sua
	@ma varchar(10) , @ten nvarchar(100)
	as
		begin
			update nhomsach
			set tennhomsach=@ten
			where ma_nhomsach=@ma
		end
	--xóa nhóm sách
	create proc nhomsach_xoa
	@ma varchar(10)
	as
		begin
			if @ma in (select ma_nhomsach from dausach)
				print N'không thể xóa , nhóm sách đang có đầu sách'
			else
				begin
					delete from nhomsach
					where ma_nhomsach=@ma
				end
		end
	--trigger tự động sinh mã đầu sách 
	create trigger trg_nextIDdausach on dausach for insert
	as
		begin
			declare @lastID varchar(10)
			set @lastID= (select top 1 ma_dausach from dausach order by ma_dausach desc)
			update dausach
			set ma_dausach = dbo.func_nextID(@lastID,'DS',6)
			where ma_dausach= ''
	end
	--thêm đầu sách
	create proc dausach_them
	@mads varchar(10), @mans varchar(10), @ngonngu nvarchar(20), @tomtat nvarchar(200), @trangthai int, @ten nvarchar(100)
	as
		begin
			insert into dausach(ma_dausach, ma_nhomsach, ngonngu, tomtat, trangthai, tendausach) values(@mads, @mans,@ngonngu, @tomtat, @trangthai, @ten )
		end
	--sửa đầu sách
	create proc dausach_sua
	@mads varchar(10), @mans varchar(10), @ngonngu nvarchar(20), @tomtat nvarchar(200), @trangthai int, @ten nvarchar(100)
	as	
		begin
			update dausach
			set ma_nhomsach=@mans, ngonngu=@ngonngu, tomtat=@tomtat, trangthai=@trangthai, tendausach=@ten
			where ma_dausach=@mads
		end
	--xóa đầu sách
	create proc dausach_xoa
		@ma varchar(10)
	as
		begin
			if @ma in (select ma_dausach from cuonsach)
				print N'Không thể xóa!'
			else
				begin
					delete from dausach
					where ma_dausach= @ma
				end
		end
	-- thêm độc giả
	create proc docgia_them
		@ma varchar(10), @hoten nvarchar(50), @sdt varchar(15), @hinhanh varchar(20)
	as
		begin
			insert into docgia (ma_docgia, hoten, sodienthoai, hinhanh) values(@ma, @hoten, @sdt, @hinhanh)
		end
		-- sửa độc giả
	create proc docgia_sua
		@ma varchar(10), @hoten nvarchar(50), @sdt varchar(15), @hinhanh varchar(20)
	as
		begin
			update docgia
			set hoten=@hoten, sodienthoai = @sdt, hinhanh=@hinhanh
			where ma_docgia=@ma
		end
		--xóa độc giả
		create proc docgia_xoa
			@ma varchar(10)
		as
			begin 
					if @ma in (select ma_docgia from phieumuon)
						print N'Độc giả đang có phiếu mượn. Không thể xóa!!'
					else
						begin
							delete from docgia
							where ma_docgia=@ma
						end
			end
	--trigger mã độc giả tự động tăng
	create trigger trg_nextIDdocgia on docgia for insert
	as
		begin
			declare @lastID varchar(50)
			set @lastID= (select top 1 ma_docgia from docgia order by ma_docgia desc)
			update docgia
			set ma_docgia = dbo.func_nextID(@lastID,'DG',6)
			where ma_docgia= ''
	end
	-- trigger mã phiếu mượn tự động tăng
		create trigger trg_nextIDphieumuon on phieumuon for insert
	as
		begin
			declare @lastID varchar(50)
			set @lastID= (select top 1 ma_phieumuon from phieumuon order by ma_phieumuon desc)
			update phieumuon
			set ma_phieumuon = dbo.func_nextID(@lastID,'PM',6)
			where ma_phieumuon= ''
	end
	--thêm phiếu mượn
	create proc phieumuon_them
		@mapm varchar(10), @madg varchar(10), @ngaym date, @ngayt date
	as
		begin
			insert into phieumuon (ma_phieumuon, ma_docgia, ngaymuon, ngaytra) values(@mapm, @madg, @ngaym, @ngayt)
		end
	--sửa phiếu mượn
	create proc phieumuon_sua
		@mapm varchar(10), @madg varchar(10), @ngaym date, @ngayt date
	as
		begin
			update phieumuon
			set ma_docgia=@madg, ngaymuon=@ngaym, ngaytra= @ngayt
			where ma_phieumuon=@mapm
		end
	-- xóa phiếu mượn
	create proc phieumuon_xoa
			@ma varchar(10)
		as
			begin 
					if @ma in (select ma_phieumuon from cuonsach)
						print N'Phiếu mượn đang chứa sách. Không thể xóa!!'
					else
						begin
							delete from phieumuon
							where ma_phieumuon=@ma
						end
			end
	-- trigger mã thẻ độc giả tự động tăng
		create trigger trg_nextIDthedocgia on thedocgia for insert
	as
		begin
			declare @lastID varchar(50)
			set @lastID= (select top 1 ma_thedocgia from thedocgia order by ma_thedocgia desc)
			update thedocgia
			set ma_thedocgia = dbo.func_nextID(@lastID,'THE',6)
			where ma_thedocgia= ''
	end
	-- thêm thẻ độc giả
	create proc thedocgia_them
		@matdg varchar(10), @madg varchar(10), @ngaylt date, @ngayhh date
	as
		begin
			insert into thedocgia (ma_thedocgia,ma_docgia,ngaylamthe, ngayhethan) values(@matdg, @madg, @ngaylt,@ngayhh)
		end
	-- sửa thẻ độc giả
		create proc thedocgia_sua
		@matdg varchar(10), @madg varchar(10), @ngaylt date, @ngayhh date
	as
		begin
			update thedocgia
			set ma_docgia=@madg, ngaylamthe= @ngaylt, ngayhethan = @ngayhh
			where ma_thedocgia=@matdg
		end
		-- xóa thẻ độc giả
		create proc thedocgia_xoa
			@ma varchar(10)
		as
			
						begin
							delete from thedocgia
							where ma_thedocgia=@ma
						end
	-- trigger mã phiếu trả tự động tăng
		create trigger trg_nextIDphieutra on phieutra for insert
	as
		begin
			declare @lastID varchar(50)
			set @lastID= (select top 1 ma_phieutra from phieutra order by ma_phieutra desc)
			update phieutra
			set ma_phieutra = dbo.func_nextID(@lastID,'PT',6)
			where ma_phieutra= ''
	end
	--thêm phiếu trả
	create proc phieutra_them
		@mapt varchar(10), @mapm varchar(10), @ngaytrathat date, @tienphat float
	as
		begin
			insert into phieutra (ma_phieutra,ma_phieumuon, ngaytrathat, tienphat) values(@mapt,@mapm, @ngaytrathat,@tienphat)
		end
	-- sửa phiếu trả
		create proc phieutra_sua
		@mapt varchar(10), @mapm varchar(10), @ngaytrathat date, @tienphat float
	as
		begin
			update phieutra
			set ma_phieutra=@mapt, ngaytrathat= @ngaytrathat, tienphat = @tienphat
			where ma_phieutra=@mapt
		end
		--xóa phiếu trả
				create proc phieutra_xoa
					@ma varchar(10)
				as
			
						begin
							delete from phieutra
							where ma_phieutra=@ma
						end
	
