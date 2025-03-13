.text
.global main
main:

	jal readswitches
	
	subui $sp, $sp, 1
	sw $1, 0($sp)
	jal bitshift 
	jal bitmask
	jal compare
	

bitshift:
	srli $3, $1, 8
	jr $ra
bitmask:
	andi $4, $1, 255
	jr $ra
compare:
	slt $5, $3, $4
	bnez $5, less
	beqz $5, greater
	
less:
	add $2, $4, $0
	jal writessd
	lw $1, 0($sp)
	addui $sp, $sp, 1
	jal main
greater:
	add $2, $3, $0
	jal writessd
	lw $1, 0($sp)
	addui $sp, $sp, 1
	jal main

