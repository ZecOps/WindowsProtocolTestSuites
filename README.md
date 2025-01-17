# CVE-2020-0796 Pre-Auth POC

(c) 2020 ZecOps, Inc. - https://www.zecops.com - Find Attackers' Mistakes  
POC to check for CVE-2020-0796 / "SMBGhost"  
Expected outcome: Blue Screen  
Intended only for educational and testing in corporate environments.  
ZecOps takes no responsibility for the code, use at your own risk.  
Please contact sales@ZecOps.com if you are interested in agent-less DFIR tools for Servers, Endpoints, and Mobile Devices to detect SMBGhost and other types of attacks automatically.

## Usage

`CVE-2020-0796-POC.exe [<TargetServer>]`

If `<TargetServer>` is omitted, the POC is executed on localhost (`127.0.0.1`).

![demo](demo.gif)

## Compiled POC

You can get the compiled POC [here](https://github.com/ZecOps/CVE-2020-0796-POC/releases).

## Compiling

Use Visual Studio to compile the following projects:

1. `ProtoSDK\Asn1Base\Asn1Base.csproj`
2. `ProtoSDK\MS-XCA\Xca.csproj`
3. `ProtoSDK\MS-SMB2\Smb2.sln`

Use the resulting exe file to run the POC.

## References

* [Vulnerability Reproduction: CVE-2020-0796 POC - ZecOps Blog](https://blog.zecops.com/vulnerabilities/vulnerability-reproduction-cve-2020-0796-poc/)
* [CVE-2020-0796 - Microsoft Security Response Center](https://portal.msrc.microsoft.com/en-US/security-guidance/advisory/CVE-2020-0796)
* [SMBGhost Analysis - Lucas Georges](https://www.synacktiv.com/posts/exploit/im-smbghost-daba-dee-daba-da.html)
