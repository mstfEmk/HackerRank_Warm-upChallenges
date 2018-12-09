<?php

// Complete the repeatedString function below.
function repeatedString($s, $n) {

	$charCount = 0;
	
	for($i = 0; $i < strlen($s); $i++) {
		if ($s[$i] == 'a')
		{
			$charCount++;
		}
	}

	$repeatCount = floor($n / strlen($s));
	$remain = $n % strlen($s);
	$remainString = substr($s, 0, $remain);
	$charCount = $charCount * $repeatCount;

	for($i = 0; $i < strlen($remainString); $i++) {
		if ($s[$i] == 'a')
		{
			$charCount++;
		}
	}

	return $charCount;	
}

echo repeatedString('aba', 10);
echo repeatedString('a', 1000000000000);