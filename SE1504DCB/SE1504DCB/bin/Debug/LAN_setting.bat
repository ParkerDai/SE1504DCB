netsh interface ip set address "內網" static 10.0.50.233 255.255.0.0 10.0.0.254 1
netsh interface ip add address "內網" 12.100.100.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 10.100.100.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 100.100.100.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 192.168.0.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 192.168.1.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 192.168.2.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 11.100.100.233 255.255.255.0 10.0.0.254 1
netsh interface ip add address "內網" 192.88.74.233 255.255.255.0 10.0.0.254 1

@pause
rem 指令說明: 
rem "區域連線"是在「網路連線」裡面中網卡連線名稱
rem 後面四串是 IP_Address Sub_Mask GetWay DNS，1不可省略
rem GetWay只有一個