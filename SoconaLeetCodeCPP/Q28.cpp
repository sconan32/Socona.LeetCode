#include <string>
#include <vector>

class Q28 {

public:
	int strStr(std::string haystack, std::string needle)
	{
		if (needle == "")
		{
			return 0;
		}
		std::vector<int> next(needle.size());		
		GetNext(next, needle);
		int j = 0;
		for (int i = 0; i < haystack.size(); i++)
		{
			while (j > 0 && haystack[i] != needle[j])
			{
				j = next[j - 1];
			}
			if (haystack[i] == needle[j])
			{
				j++;
			}
			if (j == needle.size())
			{				
				return i - j + 1;
			}
		}		
		return -1;
	}

private:
	void GetNext(std::vector<int>& next, std::string needle)
	{

		next[0] = 0;
		int j = 0;
		for (int i = 1; i < needle.size(); i++)
		{
			while (j > 0 && needle[i] != needle[j])
			{
				j = next[j - 1];
			}
			if (needle[i] == needle[j])
			{
				j++;
			}
			next[i] = j;
		}
	}
};