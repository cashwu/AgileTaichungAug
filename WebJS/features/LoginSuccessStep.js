module.exports = function() {

    this.Given(/^輸入使用者名稱 "([^"]*)"$/, function(userName) {
        this.url("http://localhost:14058/Account/Login")
            .waitForElementVisible('body', 1000);

        this.setValue("input[id=UserName]", userName);
    });

    this.Given(/^輸入密碼 "([^"]*)"$/, function(password) {
       this.setValue("input[id=Password]", password);
    });

    this.Given(/^登入時$/, function() {
        this.click("input[type=submit]");
    });

    this.Given(/^成功導到 Index 頁面$/, function() {
        var expect = "http://localhost:14058/Account";
        this.assert.urlEquals(expect);
    });
};