.text
.global main
main:
	# Get the address of the welcome message
	la	$2, welcome_msg
	# Display the message
	jal	putstr
    # Clear our sum register
	add	$4, $0, $0
	# Initialise the loop counter
	addi	$5, $0, 1
	
	jal readnum
	
	add $4, $4, $1 

	# Get the sub message
	la	$2, sub_msg
	# Print it
	jal	putstr
	
	jal readnum
	
	sub $2, $4, $1  
	
	# Print out the number
	jal	writenum

	# Return to the monitor
	j	exit

.data
	# This is our welcome message
welcome_msg:
	.asciiz	"Please type a number, you would like to subtract from: "
	# This is the output message
sub_msg:
	.asciiz	"Please type the number you want subtracted: "
output_msg:
	.asciiz "The answer is: "