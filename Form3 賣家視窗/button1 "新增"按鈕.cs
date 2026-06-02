String bookname = bn.Text;

if (department.Items.IndexOf(department.Text) == -1){
    MessageBox.Show("請選擇學系", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
}else if (type.Items.IndexOf(type.Text) == -1) { 
    MessageBox.Show("請選擇類別", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
}else if(bookname == ""){
    MessageBox.Show("請輸入書籍名稱", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
}else{
    String dep = department.Text;
    String ty = type.Text;
    String msg = $"書籍名稱: {bookname}\r\n學系: {dep}\r\n類別: {ty}\r\n";
    item.Text += msg + "\r\n";
}
