.text 
.global main
main:
	#Call readswitches, that puts the switch values in $1
	jal readswitches
	#Copy $1's contents into $2, as writessd uses $2
	add $2, $0, $1
	#Call writessd to display value in $2
	jal writessd
	#Jump back to main to again read and display switches
	jal main